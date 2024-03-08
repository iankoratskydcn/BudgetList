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
    public partial class Login : UserControl
    {
        static Form1 mainForm;
        public Login(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login check


            //get username
            string username = textBox1.Text;

            //get password
            string password = textBox2.Text;

            //check data
            string pw_result = "";

            //sql query

            //if success, next screen
            if (password==pw_result)
            {
                string[] _strings = { username, password };
                int[] _ints = { };
                Form1.changeState(1, 0, _strings, _ints);
            }
            else
            {
                //if failure poppup
                MessageBox.Show("Login Failed");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
