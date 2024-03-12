using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BudgetGui.Screens
{
    public partial class registration : UserControl
    {
        static Form1 mainForm;
        public registration(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string[] _strings = { };
            int[] _ints = { };
            Form1.changeState(0, 7, _strings, _ints);
        }
    }
}
