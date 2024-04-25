using System;
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
                : new List<string>();//sqlDriver.checkFormyItems();

            List<string> itemList2 = sold_items_DT.Rows.Count > 0
                ? sold_items_DT.AsEnumerable().Select(x => x["title"].ToString()).ToList()
                : new List<string>();//sqlDriver.checkForsoldItems();


            myItems.Items.Clear();
            //List<string> itemList = sqlDriver.checkForItemsSold();
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
            //List<string> itemList2 = sqlDriver.checkForItemsSold();
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

        }

        //from  the other
        private void buy_Click(object sender, EventArgs e)
        {
            //use Josh's buy script
            sqlDriver.updated_bought_item(currently_selected_my_item.ToString());
            checkItems();
        }


        private void remove_Click(object sender, EventArgs e)
        {
            //user id
            int userid = Int32.Parse(Program.GlobalStrings[1]);
            sqlDriver.remove_saved_item(currently_selected_my_item, userid);

            //cleanup
            checkItems();
        }

        private void message_saved_Click(object sender, EventArgs e)
        {

            //get item id
            int item_id = 0;
            //get user id by item id
            int seller_id = 0;

            //get the item title
            string item_title = "";
            mainForm.passMessageScreen(seller_id, item_title);

        }


        private void message_bought_Click(object sender, EventArgs e)
        {

            //get item id
            int item_id = 0;
            //get user id by item id
            int seller_id = 0;

            //get the item title
            string item_title = "";
            mainForm.passMessageScreen(seller_id, item_title);


        }

        private void soldItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear_bought();
            currently_selected_sold_item = soldItems.SelectedIndex;

            sold_title.Clear();
            sold_desc.Clear();

            string test_t = sold_items_DT.Rows[currently_selected_sold_item]["title"].ToString();
            string test_d = sold_items_DT.Rows[currently_selected_sold_item]["desc"].ToString();
            string test_p = sold_items_DT.Rows[currently_selected_sold_item]["photoUrl"].ToString();

            if (test_t.Length > 0) { sold_title.Text = test_t; }
            if (test_d.Length > 0) { sold_desc.Text = test_d; }

            if (test_p.Length > 0)
            {
                try
                {
                    sold_pic.Image = System.Drawing.Image.FromFile(
                           Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"),
                           test_p));
                }
                catch (Exception)
                {

                }
            }
            else
            {
                sold_pic.Image = System.Drawing.Image.FromFile(
                           Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"),
                           "blank-image.png"));
            }

            sold_pic.SizeMode = PictureBoxSizeMode.StretchImage;

        }


        private void myItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear_saved();
            currently_selected_my_item = myItems.SelectedIndex;



            my_item.Clear();
            my_desc.Clear();

            string test_t = my_items_DT.Rows[currently_selected_my_item]["title"].ToString();
            string test_d = my_items_DT.Rows[currently_selected_my_item]["desc"].ToString();
            string test_p = my_items_DT.Rows[currently_selected_my_item]["photoUrl"].ToString();

            if (test_t.Length > 0) { my_item.Text = test_t; }
            if (test_d.Length > 0) { my_desc.Text = test_d; }

            if (test_p.Length > 0)
            {
                try
                {
                    my_pic.Image = System.Drawing.Image.FromFile(
                           Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"),
                           test_p));
                }
                catch (Exception)
                {

                }
            }
            else
            {
                my_pic.Image = System.Drawing.Image.FromFile(
                           Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"),
                           "blank-image.png"));
            }

            my_pic.SizeMode = PictureBoxSizeMode.StretchImage;


        }


        private void clear_saved()
        {
            my_item.Clear();
            my_desc.Clear();

            my_pic.Image = System.Drawing.Image.FromFile(
                       Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"),
                       "blank-image.png"));

            my_pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void clear_bought()
        {
            sold_title.Clear();
            sold_desc.Clear();

            sold_pic.Image = System.Drawing.Image.FromFile(
                       Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"),
                       "blank-image.png"));

            sold_pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void change_tab(object sender, EventArgs e)
        {
            clear_bought();
            clear_saved();
        }

        //for later


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
                    sold_title.Text = path;
                    sold_pic.Image = System.Drawing.Image.FromFile(path);
                    sold_pic.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }


    }
}

