using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BudgetGui.Screens.cards
{
    public partial class self_message_card : UserControl
    {
        public self_message_card(string[] strings, int[] ints)
        {
            InitializeComponent();
            string text = strings[0];
            string image_location = strings[1];

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            //set the image and text
            richTextBox1.Text = text;
            pictureBox1.Image = Image.FromFile(Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "images\\profile"), image_location));

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
