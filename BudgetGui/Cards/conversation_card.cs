using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json.Linq;
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
        private static string[] string_arguments;
        private static int[] int_arugments;
        private static string _secondary_user;
        private static messages_screen screen;

        public conversation_card(string[] _string_arguments, int[] _int_arugments, sqlDriver driver, messages_screen _screen)
        {
            screen = _screen;
            //store the arguments
            string_arguments = _string_arguments;
            int_arugments = _int_arugments;

            //unpack the arguments
            _secondary_user = _string_arguments[0];
            _secondary_user = _string_arguments[0];

            //draw
            InitializeComponent();

            DataTable j = driver.getUserById(_secondary_user);
            try
            {
                if (j.Rows[0]["profile_pic"].ToString() != "" && j.Rows[0]["profile_pic"].ToString().Length != 0 && j.Rows[0]["profile_pic"].ToString() != null)
                {
                    pictureBox1.Image = Image.FromFile(j.Rows[0]["profile_pic"].ToString());
                }
            }
            catch (Exception)
            {
            }
            linkLabel1.Text = j.Rows[0]["username"].ToString();



        }

        //when you click a convo card, it should load that conversation
        private void clicked(object sender, EventArgs e)
        {
            try
            {
                screen.change_convo(_secondary_user);
            }
            catch (Exception)
            {
            }
        }

    }
}
