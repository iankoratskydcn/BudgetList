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
        private static shopping shopping_screen;
        private static registration registration;
        private static Form1 form1;
        private static Panel panel_1;
        private static sqlDriver driver;

        private static string userId;

        public static bool isPresent = false;

        public Form1(sqlDriver _sqlDriver)
        {

            InitializeComponent();


            //create a login screen in the container
            form1 = this;
            driver = _sqlDriver;
            this.DoubleBuffered = true;
            panel_1 = this.panel1;

            _login_screen = new Login(form1);
            _login_screen.Dock = DockStyle.Fill;
            panel1.Controls.Add(_login_screen);



        }

        public void passMessageScreen(int itemId, int seller)
        {
            isPresent = true;
            changeState(6,seller);
            //message_Screen.change_convo(seller);

        }

        public void logout()
        {
            Program.GlobalStrings = new string[2];
            Program.GlobalStrings[0] = "";
            Program.GlobalStrings[1] = "";

            GC.Collect();

            Form1.changeState(0);
        }

        public static void changeState(int state, int seller = 0)
        {
            form1.SuspendLayout();
            panel_1.Controls.Clear();

            switch (state)
            {
                
                case 0: //switch to the login screen and log the user out
                    
                    form1.panel1.Controls.Add(_login_screen);
                    _login_screen.Dock = DockStyle.Fill;
                    break;
                
                case 1: //the user has selected create an account

                    if (registration == null)
                    {
                        registration = new registration(form1);
                    }

                    form1.panel1.Controls.Add(registration);
                    registration.Dock = DockStyle.Fill;
                    break;
                
                case 2: //the user has selected the main screen
                    
                    //make sure the user id is updated
                    userId = Program.GlobalStrings[1];

                    if (main_Screen == null)
                    {
                        main_Screen = new main_screen(form1);
                    }

                    form1.panel1.Controls.Add(main_Screen);
                    main_Screen.Dock = DockStyle.Fill;
                    break;
               
                case 3: //the user has selected a user view

                    if (user_View == null)
                    {
                        user_View = new user_view(form1);
                    } 

                    form1.panel1.Controls.Add(user_View);
                    user_View.Dock = DockStyle.Fill;
                    user_View.refresh_image();
                    break;
                
                case 4: //the user has selected a searched items screen

                    
                    if (search_View == null)
                    {
                        search_View = new search_view(form1);
                    }
                    
                    
                    form1.panel1.Controls.Add(search_View);
                    search_View.Dock = DockStyle.Fill;
                    search_View.dgvInitialize();
                    break;
                
                case 5: //the user has selected shopping screen

                    if (shopping_screen == null) 
                    { 
                        shopping_screen = new shopping(form1); 
                    }

                    form1.panel1.Controls.Add(shopping_screen);
                    shopping_screen.Dock = DockStyle.Fill;
                    shopping_screen.checkItems();
                    break;
                
                case 6: //the user has selected to view their messages

                    message_Screen = new messages_screen(form1, driver);

                    if (isPresent == true)
                    {
                        message_Screen._convo_from_item_start(seller);
                        isPresent = false;
                    }

                    message_Screen.convos_load();
                    message_Screen.conversations_fill();

                    form1.panel1.Controls.Add(message_Screen);
                    message_Screen.Dock = DockStyle.Fill;
                    message_Screen.messageSelected = false;
                    break;
                
                case 7: //the user has selected to view their items

                    if (items_view ==null)
                    {
                        items_view = new items_view(form1);
                    }

                    form1.panel1.Controls.Add(items_view);
                    items_view.Dock = DockStyle.Fill;
                    items_view.checkItems();
                    break;
                
                case 8: //the user has selected to create an item

                    if (_create_item_screen ==null)
                    {
                        _create_item_screen = new create_item_screen(form1);
                    }

                    form1.panel1.Controls.Add(_create_item_screen);
                    _create_item_screen.Dock = DockStyle.Fill;
                    break;


                default: //error, do nothing
                    break;
            }

            form1.ResumeLayout(true);

        }
    }
}