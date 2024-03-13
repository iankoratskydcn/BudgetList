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
    public partial class items_view : UserControl
    {
        static Form1 mainForm;
        public items_view(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1.changeState(2, 7);
        }

        private void viewItem_Click(object sender, EventArgs e)
        {
            Form1.changeState(5, 7);
        }
    }
}
