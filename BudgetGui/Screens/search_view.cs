using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BudgetGui.sql.entities;


namespace BudgetGui.Screens
{
    public partial class search_view : UserControl
    {
        sqlDriver sqlDriver = new sqlDriver();
        static Form1 mainForm;

        public search_view(Form1 _mainForm)
        {
            InitializeComponent();
            DoubleBuffered = true;
            mainForm = _mainForm;

            dataGridView = sqlDriver.searchInitalize(dataGridView);
            dataGridView.CellContentClick += new DataGridViewCellEventHandler(dataGridView_CellContentClick);
            txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
        }

        public void dgvInitialize()
        {
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            IbITotal.Text = $"Total Records: {dataGridView.RowCount}";
            dataGridView = sqlDriver.sButton("", dataGridView);
        }


        private void home_Click(object sender, EventArgs e)
        {
            Form1.changeState(2);
        }

        private void userView_Click(object sender, EventArgs e)
        {
            Form1.changeState(3);
        }

        private void items_Click(object sender, EventArgs e)
        {
            Form1.changeState(7);
        }

        private void shopping_Click(object sender, EventArgs e)
        {
            Form1.changeState(5);
        }

        private void messageScreen_Click(object sender, EventArgs e)
        {
            Form1.changeState(6);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            mainForm.logout();
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            try
            {
                //DataTable commodities = sqlDriver.sButton(txtSearch.Text);

                dataGridView = sqlDriver.sButton(txtSearch.Text, dataGridView);
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                /*
                // Create a new button column
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "buttonColumn";
                buttonColumn.Text = "Save";
                buttonColumn.HeaderText = "Save to Shopping";
                buttonColumn.UseColumnTextForButtonValue = true;

                // Add the button column to the DataGridView
                dataGridView.Columns.Add(buttonColumn);


               // dataGridView.DataSource = commodities;
                */

                IbITotal.Text = $"Total Records: {dataGridView.RowCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // If the clicked cell is in the button column
            if (e.ColumnIndex == dataGridView.Columns["buttonColumn"].Index)
            {
                // Get the values from the clicked row
                string username = dataGridView.Rows[e.RowIndex].Cells["Seller Name"].Value?.ToString() ?? "";
                string itemId = dataGridView.Rows[e.RowIndex].Cells["Item ID"].Value?.ToString() ?? "";

                if (username == Program.GlobalStrings[0])
                {
                    MessageBox.Show($"You can't save your own items");
                    return;
                }

                if (sqlDriver.checkIfItemAlreadySaved(itemId))
                {
                    // Create SQL command
                    string insertSavedItemQuery = $@"
                                INSERT INTO savedItems (itemId, title, description, creatorUserId, savedUserId, postDate, currencyType, itemPrice) 
                                SELECT itemId, title, description, sellerId, {Program.GlobalStrings[1]}, postDate, currencyType, itemPrice 
                                FROM item 
                                WHERE itemId = '{itemId}';
                            ";

                    sqlDriver.executeDbInsertQuery(insertSavedItemQuery);
                    MessageBox.Show($"Item has been saved");
                } 
                else
                {
                    MessageBox.Show($"Item is already saved");
                }
            }


            if (e.ColumnIndex == dataGridView.Columns["buttonColumn2"].Index)
            {

                // Get the values from the clicked row
                string itemId = dataGridView.Rows[e.RowIndex].Cells["Item ID"].Value?.ToString() ?? "";
                //string title = dataGridView.Rows[e.RowIndex].Cells["Title"].Value?.ToString() ?? "";
                //string description = dataGridView.Rows[e.RowIndex].Cells["Description"].Value?.ToString() ?? "";
                string sellerName = dataGridView.Rows[e.RowIndex].Cells["Seller Name"].Value?.ToString() ?? "";
                //DateTime postDate = dataGridView.Rows[e.RowIndex].Cells["Post Date"].Value is DateTime ? (DateTime)dataGridView.Rows[e.RowIndex].Cells["Post Date"].Value : DateTime.MinValue;
                //decimal itemPrice = dataGridView.Rows[e.RowIndex].Cells["Item Price"].Value is decimal ? (decimal)dataGridView.Rows[e.RowIndex].Cells["Item Price"].Value : 0;
                //string currencyType = dataGridView.Rows[e.RowIndex].Cells["Currency Type"].Value?.ToString() ?? "";

                if (sellerName == Program.GlobalStrings[0])
                {
                    MessageBox.Show($"You can't buy your own items");
                    return;
                }

                string updateBoughtItemQuery = $"UPDATE item SET buyerId = '{Program.GlobalStrings[1]}', purchaseDate = '{DateTime.Today.ToString("yyyy-MM-dd")}' WHERE itemId = '{itemId}'";

                sqlDriver.executeDbInsertQuery(updateBoughtItemQuery);
                MessageBox.Show($"Item has been bought");

                dataGridView = sqlDriver.sButton("", dataGridView);
                IbITotal.Text = $"Total Records: {dataGridView.RowCount}";



                /*
                if (sqlDriver.checkIfItemAlreadySaved(itemId))
                {
                    // Create SQL command
                    string updateBoughtItemQuery = $"UPDATE item SET buyerId = '{Program.GlobalStrings[1]}', purchaseDate = '{DateTime.Today.ToString("yyyy-MM-dd")}' WHERE itemId = '{itemId}'";

                    sqlDriver.executeDbInsertQuery(updateBoughtItemQuery);
                    MessageBox.Show($"Item has been bought");

                    //Removes bought item from saved list if saved before buying
                } 
                else
                {
                    MessageBox.Show($"Item has already been bought");
                }
                */
            }


        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                sButton.PerformClick();
        }
    }
}
