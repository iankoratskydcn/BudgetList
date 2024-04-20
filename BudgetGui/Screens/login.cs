using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudgetGui.Screens
{
    public partial class Login : UserControl
    {
        sqlDriver sqlDriver = new sqlDriver();
        static Form1 mainForm;
        public Login(Form1 _mainForm)
        {
            mainForm = _mainForm;
            InitializeComponent();
            DoubleBuffered = true;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                return;
            }

            //get username and password
            string username = textBox1.Text;
            string password = textBox2.Text;
            string result = sqlDriver.login(username, password);

            //if success, next screen
            if (username == result)
            {
                string[] strings = { sqlDriver.loggedInUsername, sqlDriver.loggedInUserId };
                Program.GlobalStrings = strings;
                Form1.changeState(2);
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1.changeState(1);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
