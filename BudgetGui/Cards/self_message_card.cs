using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetGui.Screens.cards
{
    public partial class self_message_card : UserControl
    {
        public self_message_card(string[] strings, int[] ints)
        {
            InitializeComponent();
            string text = strings[0];
            string image_location = strings[1];

            //set the image and text
            richTextBox1.Text = text;
            pictureBox1.ImageLocation = image_location;

        }
    }
}
