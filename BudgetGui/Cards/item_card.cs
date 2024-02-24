using System;
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
    public partial class item_card : UserControl
    {
        private int item_id;
        private int _screen;


        public item_card(int item_id, string title, string description, string image_location, int cur_screen)
        {
            InitializeComponent();

            //set the values
            this.item_id = item_id;

            //set the items
            linkLabel1.Text = title;
            richTextBox1.Text = description;
            pictureBox1.ImageLocation = image_location;
            _screen = cur_screen;

        }

        private void clicked(object sender, EventArgs e)
        {
            
            try
            {
                //send the args to the main screen
                Form1.changeState(4, _screen, new string[] { }, new int[] { item_id });

            }
            catch (Exception)
            {
                MessageBox.Show("Malformed Parameters");
            }

        }
    }
}
