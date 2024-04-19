using BudgetGui.Screens.cards;
using Microsoft.VisualBasic;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
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
        private static string selfId;
        private static string currentConvoId;
        private static messages_screen messages_Screen;

        static sqlDriver driver;

        public messages_screen(Form1 _mainForm, sqlDriver _sqlDriver)
        {
            InitializeComponent();
            DoubleBuffered = true;
            messages_Screen = this;
            mainForm = _mainForm;
            selfId = Program.GlobalStrings[1];
            driver = _sqlDriver;
            conversations_fill();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1.changeState(2);
        }
        private void viewConversation_Click(object sender, EventArgs e)
        {
            //Form1.changeState(8, 6);
            //instead of changing the view, we'll instead fill the conversation box

        }

        private void conversations_fill()
        {
            DataTable conversations = new DataTable();
            conversations.Load(driver.getConversations(selfId).CreateDataReader());
            int[] ints = { };

            foreach (DataRow r in conversations.Rows)
            {
                string[] strings = { r[0].ToString() };
                add_convo(strings, ints);
            }

        }

        private void add_convo(string[] strings, int[] ints)
        {
            conversation_card convo_card = new conversation_card(strings, ints, driver, messages_Screen);
            conversations.Controls.Add(convo_card);
        }

        private void add_self_msg(string[] strings, int[] ints)
        {
            self_message_card self_msg_card = new self_message_card(strings, ints);
            messages.Controls.Add(self_msg_card);
        }

        private void add_msg(string[] strings, int[] ints)
        {
            message_card msg_card = new message_card(strings, ints);
            messages.Controls.Add(msg_card);
        }

        public void change_convo(string otherId)
        {
            messages.Controls.Clear();
            List<message_card> convo_messages = driver.getMessages(selfId, otherId);
            message_card x;
            int c;
            int max_w = messages.Size.Width - 10;
            foreach (var item in convo_messages)
            {
                item.Size = new Size(max_w, 40);
                messages.Controls.Add(item);

            }
            currentConvoId = otherId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime cur = new DateTime();
            driver.SendMessage(selfId, cur, currentConvoId, richTextBox1.Text);
            richTextBox1.Text = "";

            //refresh messages
            change_convo(currentConvoId);

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Program.GlobalStrings = null;
            Form1.changeState(0);
        }

        private void userView_Click(object sender, EventArgs e)
        {
            Form1.changeState(3);
        }

        private void searchView_Click(object sender, EventArgs e)
        {
            Form1.changeState(4);
        }

        private void messageScreen_Click(object sender, EventArgs e)
        {
            Form1.changeState(6);
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
