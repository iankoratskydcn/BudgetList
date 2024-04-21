using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudgetGui.Screens
{
    public partial class create_item_screen : UserControl
    {
        sqlDriver sqlDriver = new sqlDriver();
        static Form1 mainForm;
        public create_item_screen(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
            DoubleBuffered = true;
        }

        private void createItem_Click(object sender, EventArgs e)
        {
            string monetaryPattern = @"^\d+(\.\d{2})?$";
            string[] fields = { itemTitle.Text, itemDesc.Text, itemPrice.Text };
            string[] labels = { "Title", "Description", "Price", "" };
            string _path = textBox1.Text; //for uploading an image

            if (_path == "")
            {
                _path = "blank-image.png";
            }

            for (int i = 0; i < fields.Length; i++)
            {
                if (string.IsNullOrEmpty(fields[i]))
                {
                    MessageBox.Show($"Enter your {labels[i]}");
                    return;
                }
            }
            if (!Regex.IsMatch(itemPrice.Text, monetaryPattern))
            {
                MessageBox.Show("Please provide a valid monetary value with no commas");
            }
            else
            {
                string dt = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                sqlDriver.createNewItem(itemTitle.Text,itemDesc.Text, _path, itemPrice.Text);
                MessageBox.Show("Item Created Successfully");


                Form1.changeState(7);
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

        private void items_Click(object sender, EventArgs e)
        {
            Form1.changeState(7);
        }

        private void shopping_Click(object sender, EventArgs e)
        {
            Form1.changeState(5);
        }

        private void messageScreen_Click(object sender, EventArgs e)
        {
            Form1.changeState(6);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            mainForm.logout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileloader = new OpenFileDialog();
            fileloader.Filter = "All Files (*.*)|*.*";
            fileloader.FilterIndex = 1;

            if (fileloader.ShowDialog() == DialogResult.OK)
            {
                string path = fileloader.FileName;
                textBox1.Text = path;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
