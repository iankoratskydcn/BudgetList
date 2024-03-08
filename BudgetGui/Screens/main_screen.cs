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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void change_state_template(object sender, EventArgs e)
        {

            //sql query

            //if success, next screen
            if (false)
            {
                string[] _strings = { };
                int[] _ints = { };
                Form1.changeState(1, 0, _strings, _ints);
            }
            else
            {
                //if failure
            }

        }
    }
}
