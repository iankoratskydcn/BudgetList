using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetGui.Screens
{
    public partial class items_view : UserControl
    {
        sqlDriver sqlDriver = new sqlDriver();
        static Form1 mainForm;
        public items_view(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        public void checkItems()
        {
            myItems.Items.Clear();
            List<string> itemList = sqlDriver.checkForItemsBeingSold();
            if (itemList != null)
            {
                foreach (string item in itemList)
                {
                    myItems.Items.Add(item);
                }
            }
            else
            {
                myItems.Items.Add("You have no items.");
            }
        }

        private void userView_Click(object sender, EventArgs e)
        {
            Form1.changeState(3, 7);
        }

        private void searchView_Click(object sender, EventArgs e)
        {
            Form1.changeState(4, 7);
        }

        private void messageScreen_Click(object sender, EventArgs e)
        {
            Form1.changeState(6, 7);
        }

        private void shopping_Click(object sender, EventArgs e)
        {
            Form1.changeState(9, 2);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Program.GlobalStrings = null;
            Form1.changeState(0, 7);
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            sqlDriver.createNewItem("Test");
            checkItems();
        }
    }
}
