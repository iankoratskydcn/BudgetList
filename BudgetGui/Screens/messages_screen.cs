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
        static Form1 mainForm;
        static int selfId;
        static int currentConvoId;

        static sqlDriver sqlDriver;

        public messages_screen(Form1 _mainForm)
        {
            InitializeComponent();
            mainForm = _mainForm;
            selfId = mainForm.getUserId();
            sqlDriver = new sqlDriver();
        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1.changeState(2, 6);
        }

        private void viewConversation_Click(object sender, EventArgs e)
        {
            Form1.changeState(8, 6);
        }

        private void dummy_fill()
        {
            JObject conversations = sqlDriver.getConversations(selfId);

            //
        }

        /// <summary>
        /// this will add a single conversation card to the conversation pane
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="ints"></param>
        private void add_convo(string[] strings, int[] ints)
        {
            conversation_card convo_card = new conversation_card(strings, ints);
            conversations.Controls.Add(convo_card);
        }

        /// <summary>
        /// when adding messages in bulk, use this to add the self message kind
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="ints"></param>
        private void add_self_msg(string[] strings, int[] ints)
        {
            self_message_card self_msg_card = new self_message_card(strings, ints);
            messages.Controls.Add(self_msg_card);
        }


        /// <summary>
        /// when adding messages in bulk, use this to add the other message kind
        /// </summary>
        /// <param name="strings"></param>
        /// <param name="ints"></param>
        private void add_msg(string[] strings, int[] ints)
        {
            message_card self_msg_card = new message_card(strings, ints);
            messages.Controls.Add(self_msg_card);
        }

        /// <summary>
        /// this will load a conversation
        /// </summary>
        /// <param name="id"></param>
        public void change_convo(int otherId)
        {
            messages.Controls.Clear();
            List<message_card> convo_messages = sqlDriver.getMessages(selfId, otherId);
            foreach (var item in convo_messages)
            {
                messages.Controls.Add(item);
            }
        }

        /// <summary>
        /// hit send
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime cur = new DateTime();
            sqlDriver.SendMessage(selfId, cur, currentConvoId, this.richTextBox1.Text);
        }
    }
}
