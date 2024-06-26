﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetGui.Screens
{
    public partial class items_view : UserControl
    {
        sqlDriver sqlDriver = new sqlDriver();
        static Form1 mainForm;
        DataTable my_items_DT = new DataTable();
        DataTable sold_items_DT = new DataTable();

        public items_view(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
            DoubleBuffered = true;
        }

        int currently_selected_my_item = 0;
        int currently_selected_sold_item = 0;


        public void checkItems()
        {

            //data tables
            my_items_DT.Rows.Clear();
            sold_items_DT.Rows.Clear();


            //string lists
            myItems.Items.Clear();
            soldItems.Items.Clear();

            //get info from DataTables
            my_items_DT = sqlDriver.checkForItemsBeingSold();
            sold_items_DT = sqlDriver.checkForItemsSold();


            //list comprehension
            List<string> itemList = my_items_DT.Rows.Count > 0
                ? my_items_DT.AsEnumerable().Select(x => x["title"].ToString()).ToList()
                : new List<string>();

            List<string> itemList2 = sold_items_DT.Rows.Count > 0
                ? sold_items_DT.AsEnumerable().Select(x => x["title"].ToString()).ToList()
                : new List<string>();


            myItems.Items.Clear();
            if (itemList != null)
            {
                foreach (string item in itemList)
                {
                    myItems.Items.Add(item);
                }
            }
            else
            {
                myItems.Items.Add("You have no items.");
            }

            soldItems.Items.Clear();
            if (itemList2 != null)
            {
                foreach (string item2 in itemList2)
                {
                    soldItems.Items.Add(item2);
                }
            }
            else
            {
                soldItems.Items.Add("You have no items.");
            }
        }

        //navigation
        private void userView_Click(object sender, EventArgs e)
        {
            Form1.changeState(3);
        }

        private void searchView_Click(object sender, EventArgs e)
        {
            Form1.changeState(4);
        }

        private void messageScreen_Click(object sender, EventArgs e)
        {
            Form1.changeState(6);
        }

        private void shopping_Click(object sender, EventArgs e)
        {
            Form1.changeState(5);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            mainForm.logout();
        }

        private void createItem_Click(object sender, EventArgs e)
        {
            Form1.changeState(8);
        }

        private void submit_edited_item(object sender, EventArgs e)
        {
            if(myItems.SelectedIndex==-1)
            {
                return;
            }

            if (String.Equals(my_item.Text, ""))
            {
                MessageBox.Show("Your item must have a title!");
                myItems_SelectedIndexChanged(sender, e);
                return;
            }
            if (String.Equals(my_price.Text, ""))
            {
                MessageBox.Show("Your item must have a price!");
                myItems_SelectedIndexChanged(sender, e);
                return;
            }

            bool submit = false;

            int itemId = int.Parse(my_items_DT.Rows[currently_selected_my_item]["itemId"].ToString());
            string test_t = my_items_DT.Rows[currently_selected_my_item]["title"].ToString();
            string test_pr = my_items_DT.Rows[currently_selected_my_item]["itemPrice"].ToString();


            string test_d = my_items_DT.Rows[currently_selected_my_item]["description"].ToString();
            string test_p = my_items_DT.Rows[currently_selected_my_item]["photoUrl"].ToString();


            if (!String.Equals(test_t, my_item.Text))
            {
                test_t = my_item.Text;
                submit = true;
            }
            if (!String.Equals(test_d, my_desc.Text))
            {

                test_d = my_desc.Text;
                submit = true;
            }
            if (!String.Equals(test_p, myPic_path.Text))
            {

                test_p = myPic_path.Text;
                submit = true;
            }
            if (!String.Equals(test_pr, my_price.Text))
            {

                test_pr = my_price.Text;
                submit = true;
            }

            if (submit)
            {
                sqlDriver.updateItem(itemId, test_t, test_d, test_p, test_pr);
                checkItems();
            }
        }

        private void soldItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear_bought();
            currently_selected_sold_item = soldItems.SelectedIndex;

            if (currently_selected_sold_item == -1)
            {
                return;
            }

            sold_title.Clear();
            sold_desc.Clear();

            string test_t = sold_items_DT.Rows[currently_selected_sold_item]["title"].ToString();
            string test_d = sold_items_DT.Rows[currently_selected_sold_item]["description"].ToString();
            string test_p = sold_items_DT.Rows[currently_selected_sold_item]["photoUrl"].ToString();
            string test_pr = sold_items_DT.Rows[currently_selected_sold_item]["itemPrice"].ToString();

            if (test_t.Length > 0) { sold_title.Text = test_t; }
            if (test_d.Length > 0) { sold_desc.Text = test_d; }
            if (test_pr.Length > 0) { sold_price.Text = test_pr; }

            if (test_p.Length > 0)
            {
                try
                {
                    sold_pic.Image = System.Drawing.Image.FromFile(
                           Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "images\\items"),
                           test_p));
                    sold_pic_path.Text = test_p;
                }
                catch (Exception)
                {

                }
            }
            else
            {
                sold_pic.Image = System.Drawing.Image.FromFile(
                           Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "images\\items"),
                           "blank-image.png"));
            }

            sold_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            System.GC.Collect();
        }

        private void myItems_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (myItems.SelectedIndex == -1)
            {
                return;
            }

            clear_my_item();
            currently_selected_my_item = myItems.SelectedIndex;


            my_item.Clear();
            my_desc.Clear();

            string test_t = my_items_DT.Rows[currently_selected_my_item]["title"].ToString();
            string test_d = my_items_DT.Rows[currently_selected_my_item]["description"].ToString();
            string test_p = my_items_DT.Rows[currently_selected_my_item]["photoUrl"].ToString();
            string test_pr = my_items_DT.Rows[currently_selected_my_item]["itemPrice"].ToString();

            if (test_t.Length > 0) { my_item.Text = test_t; }
            if (test_d.Length > 0) { my_desc.Text = test_d; }
            if (test_pr.Length > 0) { my_price.Text = test_pr; }

            if (test_p.Length > 0)
            {
                try
                {
                    my_pic.Image = System.Drawing.Image.FromFile(
                           Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "images\\items"),
                           test_p));
                    myPic_path.Text = test_p;
                }
                catch (Exception)
                {

                }
            }
            else
            {
                my_pic.Image = System.Drawing.Image.FromFile(
                           Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "images\\items"),
                           "blank-image.png"));
            }

            my_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            System.GC.Collect();

        }

        public void clear_my_item()
        {
            my_item.Text = "";
            my_desc.Text = "";
            my_price.Text = "";
            myPic_path.Text = "";


            my_pic.Image = System.Drawing.Image.FromFile(
                       Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "images\\items"),
                       "blank-image.png"));

            my_pic.SizeMode = PictureBoxSizeMode.StretchImage;

            System.GC.Collect();
        }

        public void clear_bought()
        {
            sold_title.Text = "";
            sold_desc.Text = "";
            sold_price.Text = "";
            sold_pic_path.Text = "";

            sold_pic.Image = System.Drawing.Image.FromFile(
                       Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "images\\items"),
                       "blank-image.png"));

            sold_pic.SizeMode = PictureBoxSizeMode.StretchImage;

            System.GC.Collect();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

            if(myItems.SelectedIndex ==-1)
            {
                return;
            }

            if (MessageBox.Show("Confirm Delete?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                checkItems();
                sqlDriver.delete_item_by_id(int.Parse(my_items_DT.Rows[currently_selected_my_item]["itemId"].ToString()));
                checkItems();
                clear_my_item();
            }
        }

        private void my_pic_button_Click(object sender, EventArgs e)
        {
            if (myItems.SelectedIndex == -1) { return; }

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
                    myPic_path.Text = path;
                    my_pic.Image = System.Drawing.Image.FromFile(path);
                    my_pic.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }

        private void message_buyer_Click(object sender, EventArgs e)
        {
            if (soldItems.SelectedIndex == -1)
            {
                MessageBox.Show($"Select a sold item");
            }
            else
            {
                int seller_id = int.Parse(sold_items_DT.Rows[soldItems.SelectedIndex]["buyerId"].ToString());

                //get the item title
                string item_title = soldItems.SelectedItem.ToString();
                mainForm.passMessageScreen(seller_id, item_title);
            }
        }

    }
}

