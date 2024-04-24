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
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudgetGui.Screens
{
    public partial class registration : UserControl
    {
        sqlDriver sqlDriver = new sqlDriver();
        static Form1 mainForm;
        public registration(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
            DoubleBuffered = true;
        }

        private void button1_Click(object sender, EventArgs e) {

            string[] fields = { firstName.Text, lastName.Text, email.Text, username.Text, password1.Text, password2.Text };
            string[] labels = { "First Name", "Last Name", "Email", "Username", "Password", "Repeat Password" };
            string emailPattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";

            for (int i = 0; i < fields.Length; i++) {
                if (string.IsNullOrEmpty(fields[i])) {
                    MessageBox.Show($"Enter your {labels[i]}");
                    return;
                }
            }
            if (!Regex.IsMatch(email.Text, emailPattern)) {
                MessageBox.Show("Invalid email address format");
            } else if (!password1.Text.Any(char.IsUpper) || !password1.Text.Any(char.IsDigit) || !password1.Text.Any(char.IsPunctuation) || password1.Text.Length < 8) {
                MessageBox.Show("Password must contain a capital letter, a digit, a special character, and have at least 8 characters");
            } else if (password1.Text != password2.Text) {
                MessageBox.Show("Passwords do not Match");
            } else if (sqlDriver.checkIfUsernameExists(username.Text)) {
                MessageBox.Show("Username Already Exists");
            } else {
                string hashedPassword = Form1.hashPassword(password1.Text);
                sqlDriver.InsertUser(firstName.Text, lastName.Text, username.Text, hashedPassword, email.Text, "blank-profile-picture.png");
                MessageBox.Show("Account Created Successfully");
                Form1.changeState(0);
            }
        }

        public void clearText()
        {
            firstName.Clear();
            lastName.Clear();
            email.Clear();
            username.Clear();
            password1.Clear();
            password2.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Form1.changeState(0);    
        }

    }
}
