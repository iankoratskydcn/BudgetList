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
    public partial class conversation_screen : UserControl
    {
        static Form1 mainForm;
        public conversation_screen(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
            DoubleBuffered = true;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form1.changeState(6);
        }
    }
}
