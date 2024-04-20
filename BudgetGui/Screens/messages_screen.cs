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
        private static int selfId;
        private static int currentConvoId;
        private static messages_screen messages_Screen;

        static sqlDriver driver;
        private static DataTable convs = new DataTable();
        static FlowLayoutPanel convos_panel;

        public messages_screen(Form1 _mainForm, sqlDriver _sqlDriver)
        {

            InitializeComponent();

            messages_Screen = this;
            mainForm = _mainForm;
            selfId = Int32.Parse(Program.GlobalStrings[1]);
            driver = _sqlDriver;
            convos_panel = this.conversations_cont;

        }

        public void convos_load()
        {
            convs.Load(driver.getConversations(selfId).CreateDataReader());
        }

        public void conversations_fill()
        {
            string[] strings = { };

            //foreach(DataRow drow in convs.Rows) {
            Parallel.ForEach(convs.AsEnumerable(), drow =>
            {
                try
                {
                    int[] ints = { (int)drow["recipient"] };
                    conversation_card convo_card = new conversation_card(strings, ints, driver, messages_Screen);
                    conversations_cont.Controls.Add(convo_card);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            });

        }

        public void _convo_from_item_start(int buyerId, int itemId)
        {
            JObject item = driver.getItemById(itemId);
            int seller = Int32.Parse(item["sellerId"].ToString());
            string text = "Hello, I just bought your " + item["title"].ToString() + " and I have a question.";


            driver.SendMessage(buyerId, DateTime.Now, seller, text);
            conversations_renew();
            Form1.changeState(6);
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

            //controls.ForEach(
            Parallel.ForEach(controls.AsParallel(),
                (e) =>
                {
                    e.Dispose();
                });

            GC.Collect();
        }


        public void change_convo(int otherId)
        {

            List<message_card> convo_messages = driver.getMessages(selfId, otherId);

            currentConvoId = otherId;
            List<Control> controls = new List<Control>();
            foreach (Control e in messages.Controls)
            {
                controls.Add(e);
            }

            messages.Controls.Clear();

            foreach (var item in convo_messages)
            {
                messages.Controls.Add(item);
            }

            //Parallel.ForEach(convo_messages.AsParallel().AsOrdered(),
            //    (e) => { messages.Controls.Add(e); } );

            //controls.ForEach(

            Parallel.ForEach(controls.AsParallel().AsOrdered(),
                (e) =>
                {
                    e.Dispose();
                });

            //controls.ForEach(e =>{e.Dispose();});
            GC.Collect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "") { return; }
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

        private void messages_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
