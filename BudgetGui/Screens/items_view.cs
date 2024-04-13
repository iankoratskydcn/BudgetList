﻿using System;
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

            soldItems.Items.Clear();
            List<string> itemList2 = sqlDriver.checkForItemsSold();
            if (itemList2 != null)
            {
                foreach (string item2 in itemList2)
                {
                    soldItems.Items.Add(item2);
                }
            }
            else
            {
                soldItems.Items.Add("You have no items.");
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

        private void messageScreen_Click(object sender, EventArgs e)
        {
            Form1.changeState(6);
        }

        private void shopping_Click(object sender, EventArgs e)
        {
            Form1.changeState(9);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Program.GlobalStrings = null;
            Form1.changeState(0);
        }

        private void createItem_Click(object sender, EventArgs e)
        {
            Form1.changeState(5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlDriver.executeDbInsertQuery($"UPDATE item SET buyerId = 1 WHERE itemId = {textBox1.Text};");
            checkItems();
        }
    }
}
