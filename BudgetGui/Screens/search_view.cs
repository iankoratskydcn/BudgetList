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
using Newtonsoft.Json.Linq;


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
            txtSearch.KeyPress += new KeyPressEventHandler(txtSearch_KeyPress);
        }

        public void dgvInitialize()
        {
            txtSearch.Clear();
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView = sqlDriver.sButton("", dataGridView);
            IbITotal.Text = $"Total Records: {dataGridView.RowCount}";

            dataGridView.Columns["Item ID"].Visible = false;
            dataGridView.Columns["Description"].Visible = false;
            dataGridView.Columns["Post Date"].Visible = false;
            dataGridView.Columns["Item Price"].Visible = false;

            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns[1].Width = 90;
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns[0].Width = 90;

            dataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns[2].Width = 90;


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
                dataGridView = sqlDriver.sButton(txtSearch.Text, dataGridView);
                dataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                IbITotal.Text = $"Total Records: {dataGridView.RowCount}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1)
            {
                return;
            }

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
                    sqlDriver.save_item(Int32.Parse(itemId));

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
                string sellerName = dataGridView.Rows[e.RowIndex].Cells["Seller Name"].Value?.ToString() ?? "";

                if (sellerName == Program.GlobalStrings[0])
                {
                    MessageBox.Show($"You can't buy your own items");
                    return;
                }

                sqlDriver.updated_bought_item(itemId);
                MessageBox.Show($"Item has been bought");


                dataGridView = sqlDriver.sButton("", dataGridView);
                IbITotal.Text = $"Total Records: {dataGridView.RowCount}";

            }

            if (e.ColumnIndex == dataGridView.Columns["buttonColumn3"].Index)
            {

                // Get the values from the clicked row
                string username = dataGridView.Rows[e.RowIndex].Cells["Seller Name"].Value?.ToString() ?? "";
                string itemId = dataGridView.Rows[e.RowIndex].Cells["Item ID"].Value?.ToString() ?? "";

                if (username == Program.GlobalStrings[0])
                {
                    MessageBox.Show($"You can't message yourself");
                    return;
                }

                JObject item = sqlDriver.getItemById(Int32.Parse(itemId));
                int seller = Int32.Parse(item["sellerId"].ToString());

                //Call func
                mainForm.passMessageScreen(seller);
            }

            int itemIdnum;
            if (e.RowIndex == dataGridView.RowCount)
            {
                itemIdnum = Int32.Parse(dataGridView.Rows[e.RowIndex - 1].Cells["Item ID"].Value.ToString());
            }
            else
            {
                itemIdnum = Int32.Parse(dataGridView.Rows[e.RowIndex].Cells["Item ID"].Value.ToString());
            }

            JObject j = sqlDriver.getItemById(itemIdnum);
            pictureBox2.Image = Image.FromFile(Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"), j["photoUrl"].ToString()));
            richTextBox1.Text = j["description"].ToString();
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = "$" + j["itemPrice"].ToString();

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                sButton.PerformClick();
        }

    }
}
