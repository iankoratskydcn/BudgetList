using Microsoft.VisualBasic;
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
    public partial class main_screen : UserControl
    {
        static Form1 mainForm;
        public main_screen(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Program.GlobalStrings = null;
            Form1.changeState(0, 2);
        }

        private void userView_Click(object sender, EventArgs e)
        {
            Form1.changeState(3, 2);
        }

        private void searchView_Click(object sender, EventArgs e)
        {
            Form1.changeState(4, 2);
        }

        private void messageScreen_Click(object sender, EventArgs e)
        {
            Form1.changeState(6, 2);
        }

        private void items_Click(object sender, EventArgs e)
        {
            Form1.changeState(7, 2);
        }

        private void shopping_Click(object sender, EventArgs e)
        {
            Form1.changeState(9, 2);
        }
    }
}
