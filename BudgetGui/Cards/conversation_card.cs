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

namespace BudgetGui.Screens.cards
{
    public partial class conversation_card : UserControl
    {
        private string[] string_arguments;
        private int[] int_arugments;
        private string user;
        private string item;
        private int conversation_id;

        public conversation_card(string[] _string_arguments, int[] _int_arugments)
        {

            //store the arguments
            string_arguments = _string_arguments;
            int_arugments = _int_arugments;

            //unpack the arguments
            user = _string_arguments[0];
            item = _string_arguments[1];
            conversation_id = _int_arugments[0];

            //draw
            InitializeComponent();
        }

        //when you click a convo card, it should load that conversation
        private void clicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                //Form1.changeState(, _string_arguments_int_arugments)
            }
            catch (Exception)
            {

                throw;
            }


        }
    }
}
