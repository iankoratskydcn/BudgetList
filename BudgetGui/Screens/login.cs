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
            sqlDriver sqlDriver = new sqlDriver();
          
            //get username and password
            string username = textBox1.Text;
            string password = textBox2.Text;

            //check data
            string passwordResult = sqlDriver.login(username, password);

            //if success, next screen
            if (username== passwordResult)
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
