using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudgetGui.Screens
{
    public partial class user_view : UserControl
    {
        sqlDriver sqlDriver = new sqlDriver();
        static Form1 mainForm;
        public user_view(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1.changeState(2, 3);
        }

        private void searchView_Click(object sender, EventArgs e)
        {
            Form1.changeState(4, 2);
        }

        private void items_Click(object sender, EventArgs e)
        {
            Form1.changeState(7, 2);
        }

        private void messageScreen_Click(object sender, EventArgs e)
        {
            Form1.changeState(6, 2);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Program.GlobalStrings = null;
            Form1.changeState(0, 2);
        }

        private void save_Click(object sender, EventArgs e)
        {
            string[] fields = { streetNum.Text, street.Text, city.Text, state.Text, zip.Text };
            string[] labels = { "Street Number", "Street", "City", "State", "Zip" };
            if (!(string.IsNullOrEmpty(streetNum.Text)) || !(string.IsNullOrEmpty(street.Text)) || !(string.IsNullOrEmpty(city.Text)) || !(string.IsNullOrEmpty(state.Text)) || !(string.IsNullOrEmpty(zip.Text)))
            {
                for (int i = 0; i < fields.Length; i++)
                {
                    if (string.IsNullOrEmpty(fields[i]))
                    {
                        MessageBox.Show($"Enter your {labels[i]}");
                        return;
                    }
                }
                sqlDriver.insertAddressToUser(streetNum.Text, street.Text, city.Text, state.Text, zip.Text);
            }

            if (!(string.IsNullOrEmpty(email.Text)))
            {
                sqlDriver.executeDbInsertQuery($"UPDATE _user SET email = '{email.Text}' WHERE userId = {Program.GlobalStrings[1]};");
            }
            
            if (!(string.IsNullOrEmpty(password.Text)))
            {
                if (!password.Text.Any(char.IsUpper) || !password.Text.Any(char.IsDigit) || !password.Text.Any(char.IsPunctuation) || password.Text.Length < 8)
                {
                    MessageBox.Show("Password must contain a capital letter, a digit, a special character, and have at least 8 characters");
                    return;
                } else
                {
                    sqlDriver.executeDbInsertQuery($"UPDATE _user SET _password = '{password.Text}' WHERE userId = {Program.GlobalStrings[1]};");
                }
            }

            if (!(string.IsNullOrEmpty(dateOfBirth.Text)))
            {
                DateTime parsedDate;
                if (!(DateTime.TryParseExact(dateOfBirth.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate)))
                {
                    MessageBox.Show("Date of Birthday must be in yyyy-MM-dd format");
                    return;
                } else
                {
                    sqlDriver.executeDbInsertQuery($"UPDATE _user SET DOB = '{dateOfBirth.Text}' WHERE userId = {Program.GlobalStrings[1]};");
                }
            }

            MessageBox.Show($"Saved Successfully");
        }
    }
}
