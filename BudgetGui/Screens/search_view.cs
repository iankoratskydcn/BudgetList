﻿using System;
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
    public partial class search_view : UserControl
    {
        static Form1 mainForm;
        public search_view(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1.changeState(2, 4);
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
    }
}
