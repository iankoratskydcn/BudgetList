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
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            int is_self = ints[0];
            this.SuspendLayout();
            if (is_self == 0)
            {
                //change to the self message card format

                //clear the controls
                this.Controls.Clear();
                self_message_card card = new self_message_card(strings, ints);
                card.Dock = DockStyle.Fill;
                this.Controls.Add(card);
            }
            else
            {
                string text = strings[0];
                int user_id = ints[0];

                string image_location = strings[2];
                //set the image and text
                richTextBox1.Text = text;
                pictureBox1.Image = Image.FromFile(Path.Combine(Path.Combine(Directory.GetCurrentDirectory(), "images\\profile"), image_location));
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            this.ResumeLayout(false);
        }

    }
}
