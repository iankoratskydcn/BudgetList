using BudgetGui.Screens;
using System.Windows.Forms;

namespace BudgetGui
{
    public partial class Form1 : Form
    {


        private static Login _login_screen;
        private static main_screen main_Screen;
        private static user_view user_View;
        private static search_view search_View;
        private static item_full_view _item_Full_view;
        private static message_screen message_Screen;
        private static conversation_screen conversation_Screen;

        private static Form1 form1;
        private static Panel panel_1;


        public Form1()
        {

            InitializeComponent();

            //create a login screen in the container
            form1 = this;
            panel_1 = this.panel1;
            _login_screen = new Login(form1);
            _login_screen.Dock = DockStyle.Fill;
            panel1.Controls.Add(_login_screen);

        }



        //for each of the states, we'll use this to switch the control
        /*
             
             case 0:
                        _login_screen = new Login();
                        break;
                    case 1:
                        _item_Full_view = new item_full_view();
                        break;
                    case 2:
                        main_Screen = new main_screen();
                        break;
                    case 3:
                        message_Screen = new message_screen();
                        break;
                    case 4:
                        search_View = new search_view();
                        break;
                    case 5:
                        user_View = new user_view();
             */
        /// <summary>
        /// 
        /// </summary>
        /// <param name="state"></param>
        /// <param name="prev_state"></param>
        /// <param name="string_arguments"></param>
        /// <param name="int_arguments"></param>
        public static void changeState(int state, int prev_state, string[] string_arguments, int[] int_arguments)
        {
            //check login to ensure that the user is logged in

            //if they're not, default to the login screen

            
            switch (state)
            {
                case 0:
                    //switch to the login screen and log the user out
                    panel_1.Controls.Clear();

                    _login_screen = new Login(form1);
                    _login_screen.Dock = DockStyle.Fill;
                    form1.panel1.Controls.Add(_login_screen);

                    break;
                case 1:
                    //the user has selected the main screen
                    panel_1.Controls.Clear();

                    main_Screen = new main_screen(form1);
                    main_Screen.Dock = DockStyle.Fill;
                    form1.panel1.Controls.Add(main_Screen);

                    break; 
                case 2:
                    //the user has selected a user view

                    panel_1.Controls.Clear();

                    user_View = new user_view(form1);
                    user_View.Dock = DockStyle.Fill;
                    form1.panel1.Controls.Add(user_View);

                    break; 
                case 3:
                    //the user has selected a searched items screen

                    panel_1.Controls.Clear();

                    search_View = new search_view(form1);
                    search_View.Dock = DockStyle.Fill;
                    form1.panel1.Controls.Add(search_View);

                    break;

                case 4:
                    //the user has selected an item view


                    panel_1.Controls.Clear();

                    _item_Full_view = new item_full_view(form1);
                    _item_Full_view.Dock = DockStyle.Fill;
                    form1.panel1.Controls.Add(_item_Full_view);

                    break;
                case 5:
                    //the user has selected to view their messages

                    panel_1.Controls.Clear();

                    message_Screen = new message_screen(form1);
                    message_Screen.Dock = DockStyle.Fill;
                    form1.panel1.Controls.Add(message_Screen);

                    break;
                case 6:
                    //the user has selected to view a particular set of messages

                    break;
                default:
                    //error, do nothing
                    break;
            }

            //check if the previous state is different, as we overwrite it
            if (prev_state != state)
            {
                //if successful, clear the previous state
                switch (prev_state)
                {
                    case 0:
                        _login_screen = new Login(form1);
                        break;
                    case 1:
                        _item_Full_view = new item_full_view(form1);
                        break;
                    case 2:
                        main_Screen = new main_screen(form1);
                        break;
                    case 3:
                        message_Screen = new message_screen(form1);
                        break;
                    case 4:
                        search_View = new search_view(form1);
                        break;
                    case 5:
                        user_View = new user_view(form1);
                        break;
                    default:
                        //error, do nothing
                        break;
                }
            }


        }
    }
}
