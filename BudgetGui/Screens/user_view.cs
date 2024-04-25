using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
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
            DoubleBuffered = true;
            mainForm = _mainForm;

            load_text_to_boxes();

        }
        public void load_text_to_boxes()
        {
            DataTable j = sqlDriver.getUserById(Int32.Parse(Program.GlobalStrings[1].ToString()));

            string v;

            v = j.Rows[0]["email"].ToString();
            email.Text = (v != "" && v.Length != 0 && v != null) ? v : "";
            v = j.Rows[0]["DOB"].ToString();
            dateOfBirth.Text = (v != "" && v.Length != 0 && v != null) ? v : "";
            v = j.Rows[0]["profile_pic"].ToString();
            img_path.Text = (v != "" && v.Length != 0 && v != null) ? v : "";
            v = j.Rows[0]["street"].ToString();
            street.Text = (v != "" && v.Length != 0 && v != null) ? v : "";
            v = j.Rows[0]["city"].ToString();
            city.Text = (v != "" && v.Length != 0 && v != null) ? v : "";
            v = j.Rows[0]["state"].ToString();
            state.Text = (v != "" && v.Length != 0 && v != null) ? v : "";
            v = j.Rows[0]["zip"].ToString();
            zip.Text = (v != "" && v.Length != 0 && v != null) ? v : "";

            pictureBox2.Image = Image.FromFile(
                        Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\profile"),
                        j.Rows[0]["profile_pic"].ToString()));
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void refresh_image()
        {
            //get the picture into the box
            DataTable j = sqlDriver.getUserById(Int32.Parse(Program.GlobalStrings[1].ToString()));
            try
            {
                if (j.Rows[0]["profile_pic"].ToString() != "" && j.Rows[0]["profile_pic"].ToString().Length != 0 && j.Rows[0]["profile_pic"].ToString() != null)
                {

                    pictureBox2.Image = Image.FromFile(
                        Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\profile"),
                        j.Rows[0]["profile_pic"].ToString()));
                }
            }
            catch (Exception)
            {
            }
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1.changeState(2);
        }

        private void searchView_Click(object sender, EventArgs e)
        {
            Form1.changeState(4);
        }

        private void items_Click(object sender, EventArgs e)
        {
            Form1.changeState(7);
        }

        private void messageScreen_Click(object sender, EventArgs e)
        {
            Form1.changeState(6);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            mainForm.logout();
        }

        private void shopping_Click(object sender, EventArgs e)
        {
            Form1.changeState(5);
        }

        

        private void save_Click(object sender, EventArgs e)
        {
            string[] fields = { street.Text, city.Text, state.Text, zip.Text };
            string[] labels = { "Street", "City", "State", "Zip" };
            string emailPattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";

            if (!(string.IsNullOrEmpty(street.Text)) || !(string.IsNullOrEmpty(city.Text)) || !(string.IsNullOrEmpty(state.Text)) || !(string.IsNullOrEmpty(zip.Text)))
            {
                for (int i = 0; i < fields.Length; i++)
                {
                    if (string.IsNullOrEmpty(fields[i]))
                    {
                        MessageBox.Show($"Enter your {labels[i]}");
                        return;
                    }
                }
                sqlDriver.insertAddressToUser(street.Text, city.Text, state.Text, zip.Text);
            }

            if (!(string.IsNullOrEmpty(email.Text)))
            {
                if (!Regex.IsMatch(email.Text, emailPattern))
                {
                    MessageBox.Show("Invalid email address format");
                    return;
                } else
                {
                    sqlDriver.updateEmail(email.Text);
                }
            }

            if (!(string.IsNullOrEmpty(password.Text)))
            {
                if (!password.Text.Any(char.IsUpper) || !password.Text.Any(char.IsDigit) || !password.Text.Any(char.IsPunctuation) || password.Text.Length < 8)
                {
                    MessageBox.Show("Password must contain a capital letter, a digit, a special character, and have at least 8 characters");
                    return;
                }
                else
                {
                    string hashedPassword = Form1.hashPassword(password.Text);
                    sqlDriver.updatePW(hashedPassword);
                }
            }

            if (!(string.IsNullOrEmpty(dateOfBirth.Text)))
            {
                DateTime parsedDate;
                if (!(DateTime.TryParseExact(dateOfBirth.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate)))
                {
                    MessageBox.Show("Date of Birthday must be in yyyy-MM-dd format");
                    return;
                }
                else
                {

                    sqlDriver.updateDoB(dateOfBirth.Text);
                }
            }


            if (!(string.IsNullOrEmpty(img_path.Text)))
            {

                sqlDriver.updateProfilePic(img_path.Text);

                img_path.Text = "";
                refresh_image();
            }

            load_text_to_boxes();
            MessageBox.Show($"Saved Successfully");
        }

        private void img_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileloader = new OpenFileDialog();
            fileloader.Filter = "All Files (*.*)|*.*";
            fileloader.FilterIndex = 1;

            if (fileloader.ShowDialog() == DialogResult.OK)
            {
                string path = fileloader.FileName;

                if (path.Split('.').Length != 2 || path.Split('.')[1] != "png")
                {
                    MessageBox.Show("Please select a png file");
                }
                else
                {
                    img_path.Text = path;
                    pictureBox2.Image = System.Drawing.Image.FromFile(path);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }

    }
}
