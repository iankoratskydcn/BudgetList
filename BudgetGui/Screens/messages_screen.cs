using BudgetGui.Screens.cards;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BudgetGui.Screens
{
    public partial class messages_screen : UserControl
    {
        private static Form1 mainForm;
        private static int currentConvoId;
        private static messages_screen messages_Screen;

        static sqlDriver driver;
        private static DataTable convs = new DataTable();

        public messages_screen(Form1 _mainForm, sqlDriver _sqlDriver)
        {

            InitializeComponent();

            messages_Screen = this;
            mainForm = _mainForm;
            driver = _sqlDriver;

        }

        public void convos_load()
        {
            conversations_cont.Controls.Clear();
            convs = new DataTable();
            int selfId = Int32.Parse(Program.GlobalStrings[1]);
            convs.Load(driver.getConversations(selfId).CreateDataReader());

            
        }


        public void conversations_fill()
        {
            conversations_cont.Controls.Clear();
            string[] strings = { };

            foreach (DataRow drow in convs.Rows)
            {
                int[] ints = { (int)drow["ID"] };
                conversation_card convo_card = new conversation_card(strings, ints, driver, messages_Screen);
                conversations_cont.Controls.Add(convo_card);
            }

            List<conversation_card> convo_controls = new List<conversation_card>();

            foreach (conversation_card convo in conversations_cont.Controls)
            {
                convo_controls.Add(convo);
            }

            convo_controls.ForEach(
               (e) =>
               {
                   e.set_black();
               });
        }

        public void _convo_from_item_start(int seller, string itemTitle)
        {
            string text = "Hello, I have a question about" + itemTitle +"?";
            driver.SendMessage(Int32.Parse(Program.GlobalStrings[1]), DateTime.Now, seller, text);
            conversations_renew();
            change_convo(seller);
            
        }

        public void conversations_renew()
        {

            convos_load();

            List<Control> controls = new List<Control>();
            foreach (Control e in conversations_cont.Controls)
            {
                controls.Add(e);
            }

            conversations_cont.Controls.Clear();

            conversations_fill();

            Parallel.ForEach(controls.AsParallel(),
                (e) =>
                {
                    e.Dispose();
                });

            GC.Collect();

            richTextBox1.Text = "";
        }

        public void change_convo(int otherId)
        {
            //messageSelected = true;
            int selfId = Int32.Parse(Program.GlobalStrings[1]);
            List<message_card> convo_messages = driver.getMessages(selfId, otherId);

            currentConvoId = otherId;
            List<Control> controls = new List<Control>();
            List<conversation_card> convo_controls = new List<conversation_card>();

            foreach (Control mess in messages.Controls)
            {
                controls.Add(mess);
            }

            foreach (conversation_card convo in conversations_cont.Controls)
            {
                convo_controls.Add(convo);
            }

            messages.Controls.Clear();

            foreach (var item in convo_messages)
            {
                messages.Controls.Add(item);
            }

            convo_controls.ForEach(
                (e) =>
                {
                    if (e.get_id() != otherId)
                    {
                        e.set_black();
                    }
                    else
                    {
                        e.set_grey();
                    }
                });

            //Parallel.ForEach(controls.AsParallel().AsOrdered(),
            controls.ForEach(
                (e) =>
                {
                    e.Dispose();
                });

            GC.Collect();
        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("Test");
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Test");
            if (richTextBox1.Text == "") { return; }

            //if (messageSelected == false) { return; }

            int selfId = Int32.Parse(Program.GlobalStrings[1]);
            driver.SendMessage(selfId, DateTime.Now, currentConvoId, richTextBox1.Text.Trim());
            richTextBox1.Text = "";

            //refresh messages
            change_convo(currentConvoId);

        }

        private void logout_Click(object sender, EventArgs e)
        {
            mainForm.logout();
        }

        private void userView_Click(object sender, EventArgs e)
        {
            Form1.changeState(3);
        }

        private void searchView_Click(object sender, EventArgs e)
        {
            Form1.changeState(4);
        }

        private void items_Click(object sender, EventArgs e)
        {
            Form1.changeState(7);
        }

        private void shopping_Click(object sender, EventArgs e)
        {
            Form1.changeState(5);
        }
    }
}
