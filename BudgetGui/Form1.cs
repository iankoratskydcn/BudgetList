using BudgetGui.Screens;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection;
using System.Windows.Forms;

namespace BudgetGui
{
    public partial class Form1 : Form
    {

        private static Login _login_screen;
        private static main_screen main_Screen;
        private static user_view user_View;
        private static search_view search_View;
        private static items_view items_view;
        private static item_full_view _item_Full_view;
        private static messages_screen message_Screen;
        private static conversation_screen conversation_Screen;
        private static registration registration;
        private static Form1 form1;
        private static Panel panel_1;

        private static int userId;

        public int getUserId()
        {
            return userId;
        }

        public Form1()
        {
            InitializeComponent();

            //create a login screen in the container
            form1 = this;
            this.DoubleBuffered = true;
            panel_1 = this.panel1;
            panel_1.SetDoubleBuffered();

            _login_screen = new Login(form1);
            registration = new registration(form1);
            main_Screen = new main_screen(form1);
            user_View = new user_view(form1);
            search_View = new search_view(form1);
            _item_Full_view = new item_full_view(form1);
            message_Screen = new messages_screen(form1);
            items_view = new items_view(form1);
            conversation_Screen = new conversation_screen(form1);

            _login_screen.Dock = DockStyle.Fill;
            panel1.Controls.Add(_login_screen);

        }



        public static void changeState(int state, int prev_state, string[] string_arguments = null, int[] int_arguments = null)
        {
            //check login to ensure that the user is logged in. If they're not, default to the login screen
            

            panel_1.Controls.Clear();
            switch (state)
            {
                case 0: //switch to the login screen and log the user out

                    userId = int_arguments[0];

                    form1.panel1.Controls.Add(_login_screen);

                    break;
                case 1: //the user has selected create an account                    
                    form1.panel1.Controls.Add(registration);
                    break;
                case 2: //the user has selected the main screen
                    form1.panel1.Controls.Add(main_Screen);
                    break;
                case 3: //the user has selected a user view
                    form1.panel1.Controls.Add(user_View);
                    break;
                case 4: //the user has selected a searched items screen
                    form1.panel1.Controls.Add(search_View);
                    break;
                case 5: //the user has selected an item view
                    form1.panel1.Controls.Add(_item_Full_view);
                    break;
                case 6: //the user has selected to view their messages
                    form1.panel1.Controls.Add(message_Screen);
                    break;
                case 7: //the user has selected to view their items
                    form1.panel1.Controls.Add(items_view);
                    break;
                case 8: //the user has selected to view a specific conversation
                    form1.panel1.Controls.Add(conversation_Screen);
                    break;
                default: //error, do nothing
                    break;
            }


        }
    }

    public static class MyExtensions
    {
        public static void SetDoubleBuffered(this Panel panel)
        {
            typeof(Panel).InvokeMember(
               "DoubleBuffered",
               BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
               null,
               panel,
               new object[] { true });
        }
    }
}