using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            mainForm = _mainForm;
            //"SELECT itemid, title, description, postDate, sellerId, currencyType, itemPrice FROM item"

            
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
            Program.GlobalStrings = null;
            Form1.changeState(0);
        }

        private void sButton_Click(object sender, EventArgs e)
        {
            try
            {
                //DataTable commodities = sqlDriver.sButton(txtSearch.Text);

                dataGridView = sqlDriver.sButton(txtSearch.Text, dataGridView);


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
                string itemId = dataGridView.Rows[e.RowIndex].Cells["itemId"].Value.ToString();
                string title = dataGridView.Rows[e.RowIndex].Cells["title"].Value.ToString();
                string description = dataGridView.Rows[e.RowIndex].Cells["description"].Value.ToString();
                int sellerId = (int)dataGridView.Rows[e.RowIndex].Cells["sellerId"].Value;
                DateTime postDate = (DateTime)dataGridView.Rows[e.RowIndex].Cells["postDate"].Value;
                decimal itemPrice = (decimal)dataGridView.Rows[e.RowIndex].Cells["itemPrice"].Value;
                string currencyType = dataGridView.Rows[e.RowIndex].Cells["currencyType"].Value.ToString();

                //int savedUserID;

                // Create SQL command
                string sql = $"INSERT INTO savedItems (itemId, title, description, sellerId, postDate, currencyType, itemPrice) " +
                             $"VALUES ('{itemId}', '{title}', '{description}',{sellerId}, '{postDate.ToString("yyyy-MM-dd")}', '{currencyType}', {itemPrice})";

                // Execute SQL command
                using (SqlConnection conn = new SqlConnection(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "budgetList.db")))
                {
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }

                // Show a message
                MessageBox.Show($"Item with id {itemId} saved.");
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                sButton.PerformClick();
        }
    }
}
