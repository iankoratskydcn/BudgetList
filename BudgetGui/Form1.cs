using BudgetGui.Screens;
using Microsoft.VisualBasic;
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
        private static create_item_screen _create_item_screen;
        private static messages_screen message_Screen;
        //private static conversation_screen conversation_Screen;
        private static shopping shopping_screen;
        private static registration registration;
        private static Form1 form1;
        private static Panel panel_1;
        private static sqlDriver driver;
        

        private static string userId;


        public Form1(sqlDriver _sqlDriver)
        {
            InitializeComponent();

            //create a login screen in the container
            form1 = this;
            driver = _sqlDriver;
            this.DoubleBuffered = true;
            panel_1 = this.panel1;
            panel_1.SetDoubleBuffered();

            _login_screen = new Login(form1);
            _login_screen.Dock = DockStyle.Fill;
            panel1.Controls.Add(_login_screen);

        }



        public static void changeState(int state, string[] string_arguments = null, int[] int_arguments = null)
        {
            //check login to ensure that the user is logged in. If they're not, default to the login screen

            panel_1.Controls.Clear();
            switch (state)
            {
                case 0: //switch to the login screen and log the user out

                    form1.panel1.Controls.Add(_login_screen);
                    _login_screen.Dock = DockStyle.Fill;

                    break;
                case 1: //the user has selected create an account
                    registration = new registration(form1);
                    form1.panel1.Controls.Add(registration);
                    registration.Dock = DockStyle.Fill;
                    break;
                case 2: //the user has selected the main screen

                    //make sure the user id is updated
                    userId = Program.GlobalStrings[1];

                    main_Screen = new main_screen(form1);
                    form1.panel1.Controls.Add(main_Screen);
                    main_Screen.Dock = DockStyle.Fill;
                    break;
                case 3: //the user has selected a user view
                    user_View = new user_view(form1);
                    form1.panel1.Controls.Add(user_View);
                    user_View.Dock = DockStyle.Fill;
                    break;
                case 4: //the user has selected a searched items screen
                    search_View = new search_view(form1);
                    form1.panel1.Controls.Add(search_View);
                    search_View.Dock = DockStyle.Fill;
                    break;
                case 5: //the user has selected shopping screen
                    shopping_screen = new shopping(form1);
                    form1.panel1.Controls.Add(shopping_screen);
                    shopping_screen.Dock = DockStyle.Fill;
                    break;
                case 6: //the user has selected to view their messages
                    message_Screen = new messages_screen(form1, driver);
                    form1.panel1.Controls.Add(message_Screen);
                    message_Screen.Dock = DockStyle.Fill;
                    break;
                case 7: //the user has selected to view their items
                    items_view = new items_view(form1);
                    form1.panel1.Controls.Add(items_view);
                    items_view.Dock = DockStyle.Fill;
                    break;
                //case 8: //the user has selected to view a specific conversation
                //    conversation_Screen = new conversation_screen(form1);
                //    form1.panel1.Controls.Add(conversation_Screen);
                //    conversation_Screen.Dock = DockStyle.Fill;
                //    break;
                    items_view.checkItems();
                    break;
                case 8: //the user has selected to create an item
                    _create_item_screen = new create_item_screen(form1);
                    form1.panel1.Controls.Add(_create_item_screen);
                    _create_item_screen.Dock = DockStyle.Fill;
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