using BudgetGui.Screens;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection;
using System.Text;
using System.Security.Cryptography;
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

        public void passMessageScreen(int seller, string itemTitle)
        {
            isPresent = true;
            changeState(6, seller, itemTitle);
        }

        public static string hashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public void logout()
        {
            Program.GlobalStrings = new string[2];
            Program.GlobalStrings[0] = "";
            Program.GlobalStrings[1] = "";

            GC.Collect();

            Form1.changeState(0);
        }

        public static void changeState(int state, int seller = 0, string itemTitle ="")
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
                    registration.clearText();
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
                    user_View.load_text_to_boxes();
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
                        message_Screen._convo_from_item_start(seller, itemTitle);
                        isPresent = false;
                    }

                    message_Screen.convos_load();
                    message_Screen.conversations_fill();

                    form1.panel1.Controls.Add(message_Screen);
                    message_Screen.Dock = DockStyle.Fill;
                    break;

                case 7: //the user has selected to view their items

                    if (items_view == null)
                    {
                        items_view = new items_view(form1);
                    }

                    form1.panel1.Controls.Add(items_view);
                    items_view.Dock = DockStyle.Fill;
                    items_view.checkItems();
                    break;

                case 8: //the user has selected to create an item

                    if (_create_item_screen == null)
                    {
                        _create_item_screen = new create_item_screen(form1);
                    }

                    form1.panel1.Controls.Add(_create_item_screen);
                    _create_item_screen.Dock = DockStyle.Fill;
                    _create_item_screen.clearText();
                    break;

                default: //error, do nothing
                    break;
            }
            if (shopping_screen != null)
            {
                shopping_screen.clear_bought();
                shopping_screen.clear_saved();
            }

            if (items_view != null)
            {
                items_view.checkItems();
                items_view.clear_my_item();
                items_view.clear_bought();

            }
            if(search_View != null)
            {
                search_View.clearIt();
            }

            System.GC.Collect();
            form1.ResumeLayout(true);


        }

    }
}