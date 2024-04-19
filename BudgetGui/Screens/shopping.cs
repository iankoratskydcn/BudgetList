using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetGui.Screens
{
    public partial class shopping : UserControl
    {
        sqlDriver sqlDriver = new sqlDriver();
        static Form1 mainForm;
        public shopping(Form1 _mainForm)
        {
            InitializeComponent();
            DoubleBuffered = true;
            mainForm = _mainForm;
        }

        public void checkItems()
        {
            savedItems.Items.Clear();
            List<string> itemList = sqlDriver.checkForSavedItems();
            if (itemList != null)
            {
                foreach (string item in itemList)
                {
                    savedItems.Items.Add(item);
                }
            }
            else
            {
                savedItems.Items.Add("You have no items.");
            }

            boughtItems.Items.Clear();
            List<string> itemList2 = sqlDriver.checkForBoughtItems();
            if (itemList2 != null)
            {
                foreach (string item2 in itemList2)
                {
                    boughtItems.Items.Add(item2);
                }
            }
            else
            {
                boughtItems.Items.Add("You have no items.");
            }
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
