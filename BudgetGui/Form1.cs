using BudgetGui.Screens;

namespace BudgetGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //create a login screen in the container


        }

        private static Login _login_screen = new Login();
        private static item_full_view _item_Full_view = new item_full_view();
        private static main_screen main_Screen = new main_screen();
        private static message_screen message_Screen = new message_screen();
        private static search_view search_View = new search_view();
        private static user_view user_View = new user_view();



        //for each of the states, we'll use this to switch the control
        public static void changeState(int state, int prev_state, string[] string_arguments, int[] int_arguments)
        {
            //check login to ensure that the user is logged in

            //if they're not, default to the login screen


            switch (state)
            {
                case 0:
                    //the user has logged out, switch to the login screen

                    break;
                case 1:
                    //the user has selected the main screen

                    break; 
                case 2:
                    //the user has selected a user view

                    break; 
                case 3:
                    //the user has selected a searched items screen

                    break;

                case 4:
                    //the user has selected an item view

                    break;
                case 5:
                    //the user has selected to view their messages

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
                        break;
                    default:
                        //error, do nothing
                        break;
                }
            }


        }
    }
}
