using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            Form1.changeState(9);
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
            //dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();
            // Create a new button column
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "buttonColumn";
            buttonColumn.Text = "Save";
            buttonColumn.HeaderText = "B";
            buttonColumn.UseColumnTextForButtonValue = true;

            // Add the button column to the DataGridView
            dataGridView.Columns.Add(buttonColumn);

            try
            {
                List<Commodity> commodities = sqlDriver.sButton(txtSearch.Text);
                dataGridView.DataSource = commodities;
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
                // Get the id of the item in the clicked row, for example
                int itemId = (int)dataGridView.Rows[e.RowIndex].Cells["itemId"].Value;

                // Perform an action with the item id
                MessageBox.Show($"Button in row {e.RowIndex}, item id {itemId} clicked.");
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                sButton.PerformClick();
        }
    }
}
