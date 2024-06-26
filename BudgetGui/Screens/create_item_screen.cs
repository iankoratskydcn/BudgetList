﻿using Microsoft.VisualBasic.ApplicationServices;
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
                sqlDriver.createNewItem(itemTitle.Text, itemDesc.Text, _path, itemPrice.Text);
                pictureBox2.Image = System.Drawing.Image.FromFile(
                        Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "images\\items"),
                        "blank-image.png"));
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

                Form1.changeState(7);
            }

            System.GC.Collect();
        }

        public void clearText()
        {
            itemTitle.Clear();
            itemDesc.Clear();
            itemPrice.Clear();
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
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
                    textBox1.Text = path;
                    pictureBox2.Image = System.Drawing.Image.FromFile(path);
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }

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

        
    }
}
