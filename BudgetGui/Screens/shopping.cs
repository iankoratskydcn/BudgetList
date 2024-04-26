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

namespace BudgetGui.Screens
{
    public partial class shopping : UserControl
    {
        DataTable saved_items_DT = new DataTable();
        DataTable bought_items_DT = new DataTable();
        sqlDriver sqlDriver = new sqlDriver();
        static Form1 mainForm;

        int currently_selected_saved_item = 0;
        int currently_selected_bought_item = 0;

        public shopping(Form1 _mainForm)
        {
            InitializeComponent();
            DoubleBuffered = true;
            mainForm = _mainForm;
        }

        public void checkItems()
        {
            button2.Text = "Buy for $--";

            //data tables
            saved_items_DT.Rows.Clear();
            bought_items_DT.Rows.Clear();


            //string lists
            savedItems.Items.Clear();
            boughtItems.Items.Clear();

            //get info from DataTables
            saved_items_DT = sqlDriver.checkForSavedItems();
            bought_items_DT = sqlDriver.checkForBoughtItems();

            //list comprehension
            List<string> itemList = saved_items_DT.Rows.Count > 0
                ? saved_items_DT.AsEnumerable().Select(x => x["title"].ToString()).ToList()
                : new List<string>();//sqlDriver.checkForSavedItems();
            List<string> itemList2 = bought_items_DT.Rows.Count > 0
                ? bought_items_DT.AsEnumerable().Select(x => x["title"].ToString()).ToList()
                : new List<string>();//sqlDriver.checkForBoughtItems();
            
            if (itemList != null)
            {
                foreach (string item in itemList)
                {
                    savedItems.Items.Add(item);
                }
            }
            else
            {
                savedItems.Items.Add("You have no items.");
            }

            if (itemList2 != null)
            {
                foreach (string item2 in itemList2)
                {
                    boughtItems.Items.Add(item2);
                }
            }
            else
            {
                boughtItems.Items.Add("You have no items.");
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

        private void messageScreen_Click(object sender, EventArgs e)
        {
            Form1.changeState(6);
        }

        private void logout_Click(object sender, EventArgs e)
        {
            mainForm.logout();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            if (savedItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item");
                return;
            }
            sqlDriver.updated_bought_item(int.Parse(saved_items_DT.Rows[currently_selected_saved_item]["itemId"].ToString()));
            MessageBox.Show("Item Bought!");
            clear_saved();
            checkItems();
        }


        private void remove_Click(object sender, EventArgs e)
        {

            if (savedItems.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Item");
                return;
            }
            //user id
            int userid = Int32.Parse(Program.GlobalStrings[1]);

            sqlDriver.remove_saved_item(int.Parse(saved_items_DT.Rows[currently_selected_saved_item]["itemId"].ToString()), userid);

            //cleanup
            checkItems();
            clear_saved();
        }

        private void message_saved_Click(object sender, EventArgs e)
        {
            if (savedItems.SelectedIndex == -1)
            {
                MessageBox.Show($"Select a saved item");
            }
            else
            {
                //get user id by item id
                int seller_id = int.Parse(saved_items_DT.Rows[savedItems.SelectedIndex]["sellerId"].ToString());

                //get the item title

                string item_title = savedItems.SelectedItem.ToString();
                mainForm.passMessageScreen(seller_id, item_title);
            }
        }


        private void message_bought_Click(object sender, EventArgs e)
        {
            if (boughtItems.SelectedIndex == -1)
            {
                MessageBox.Show($"Select a bought item");
            }
            else
            {
                //get user id by item id
                int seller_id = int.Parse(bought_items_DT.Rows[boughtItems.SelectedIndex]["sellerId"].ToString());

                //get the item title

                string item_title = boughtItems.SelectedItem.ToString();
                mainForm.passMessageScreen(seller_id, item_title);
            }
        }

        private void boughtItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear_bought();
            currently_selected_bought_item = boughtItems.SelectedIndex;

            bought_title.Clear();
            bought_desc.Clear();

            string test_t = bought_items_DT.Rows[currently_selected_bought_item]["title"].ToString();
            string test_d = bought_items_DT.Rows[currently_selected_bought_item]["description"].ToString();
            string test_p = bought_items_DT.Rows[currently_selected_bought_item]["photoUrl"].ToString();

            if (test_t.Length > 0) { bought_title.Text = test_t; }
            if (test_d.Length > 0) { bought_desc.Text = test_d; }

            if (test_p.Length > 0)
            {
                try
                {
                    bought_pic.Image = System.Drawing.Image.FromFile(
                           Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"),
                           test_p));
                }
                catch (Exception)
                {

                }
            }
            else
            {
                bought_pic.Image = System.Drawing.Image.FromFile(
                           Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"),
                           "blank-image.png"));
            }

            bought_pic.SizeMode = PictureBoxSizeMode.StretchImage;

        }


        private void savedItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear_saved();
            currently_selected_saved_item = savedItems.SelectedIndex;

            saved_Title.Clear();
            saved_Desc.Clear();
            string cols = "";
            foreach (DataColumn column in saved_items_DT.Columns)
            {
                cols = column.ColumnName + ", " + cols;
            }
            //MessageBox.Show(cols);



            string test_t = saved_items_DT.Rows[currently_selected_saved_item]["title"].ToString();
            string test_d = saved_items_DT.Rows[currently_selected_saved_item]["description"].ToString();
            string test_p = saved_items_DT.Rows[currently_selected_saved_item]["photoUrl"].ToString();
            string test_pr = saved_items_DT.Rows[currently_selected_saved_item]["itemPrice"].ToString();

            if (test_t.Length > 0) { saved_Title.Text = test_t; }
            if (test_d.Length > 0) { saved_Desc.Text = test_d; }
            if (test_pr.Length > 0)
            {
                
                button2.Text = "Buy for $" + test_pr;
            }



            if (test_p.Length > 0)
            {
                try
                {
                    saved_pic.Image = System.Drawing.Image.FromFile(
                           Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"),
                           test_p));
                }
                catch (Exception)
                {

                }
            }
            else
            {
                saved_pic.Image = System.Drawing.Image.FromFile(
                           Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"),
                           "blank-image.png"));
            }

            saved_pic.SizeMode = PictureBoxSizeMode.StretchImage;


        }


        public void clear_saved()
        {
            saved_Title.Clear();
            saved_Desc.Clear();

            saved_pic.Image = System.Drawing.Image.FromFile(
                       Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"),
                       "blank-image.png"));

            saved_pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void clear_bought()
        {
            bought_title.Clear();
            bought_desc.Clear();

            bought_pic.Image = System.Drawing.Image.FromFile(
                       Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\images\\items"),
                       "blank-image.png"));

            bought_pic.SizeMode = PictureBoxSizeMode.StretchImage;
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
                    bought_title.Text = path;
                    bought_pic.Image = System.Drawing.Image.FromFile(path);
                    bought_pic.SizeMode = PictureBoxSizeMode.StretchImage;
                }

            }
        }

    }
}
