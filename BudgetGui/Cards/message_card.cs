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
        public message_card(string text, string image_location)
        {
            InitializeComponent();

            //set the image and text
            richTextBox1.Text = text;
            pictureBox1.ImageLocation = image_location;            
        }
    }
}
