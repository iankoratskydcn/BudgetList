using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudgetGui.Screens
{
    public partial class create_item_screen : UserControl
    {
        sqlDriver sqlDriver = new sqlDriver();
        static Form1 mainForm;
        public create_item_screen(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void createItem_Click(object sender, EventArgs e)
        {
            string monetaryPattern = @"^\d+(\.\d{2})?$";
            string[] fields = { itemTitle.Text, itemDesc.Text, itemPrice.Text };
            string[] labels = { "Title", "Description", "Price" };

            for (int i = 0; i < fields.Length; i++)
            {
                if (string.IsNullOrEmpty(fields[i]))
                {
                    MessageBox.Show($"Enter your {labels[i]}");
                    return;
                }
            }
            if (!Regex.IsMatch(itemPrice.Text, monetaryPattern))
            {
                MessageBox.Show("Please provide a valid monetary value with no commas");
            }
            else
            {
                sqlDriver.createNewItem(itemTitle.Text, itemDesc.Text, itemPrice.Text);
                MessageBox.Show("Account Created Successfully");
                Form1.changeState(7);
            }
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userView_Click(object sender, EventArgs e)
        {
            Form1.changeState(3);
        }

        private void searchView_Click(object sender, EventArgs e)
        {
            Form1.changeState(4);
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
    }
}
