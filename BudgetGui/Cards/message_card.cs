using BudgetGui.Screens.cards;
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
    public partial class message_card : UserControl
    {
        public message_card(string[] strings, int[] ints)
        {
            InitializeComponent();
            string text = strings[0];
            string image_location = strings[1];

            //set the image and text
            richTextBox1.Text = text;
            pictureBox1.ImageLocation = image_location;

            int is_self = ints[0];

            if(is_self == 0 )
            {
                //change to the self message card format
            }

        }
    }
}
