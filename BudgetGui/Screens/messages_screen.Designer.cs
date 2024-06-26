﻿namespace BudgetGui.Screens
{
    partial class messages_screen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(messages_screen));
            label1 = new Label();
            conversations_cont = new FlowLayoutPanel();
            messages = new FlowLayoutPanel();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            shopping = new Button();
            items = new Button();
            searchView = new Button();
            userView = new Button();
            logout = new Button();
            messageScreen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(130, 44);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 6;
            label1.Text = "Messages";
            // 
            // conversations_cont
            // 
            conversations_cont.AutoScroll = true;
            conversations_cont.BackgroundImage = (Image)resources.GetObject("conversations_cont.BackgroundImage");
            conversations_cont.BackgroundImageLayout = ImageLayout.Stretch;
            conversations_cont.FlowDirection = FlowDirection.TopDown;
            conversations_cont.Location = new Point(141, 104);
            conversations_cont.Name = "conversations_cont";
            conversations_cont.Size = new Size(187, 335);
            conversations_cont.TabIndex = 9;
            conversations_cont.UseWaitCursor = true;
            conversations_cont.WrapContents = false;
            // 
            // messages
            // 
            messages.AutoScroll = true;
            messages.BackColor = SystemColors.Control;
            messages.BackgroundImage = (Image)resources.GetObject("messages.BackgroundImage");
            messages.FlowDirection = FlowDirection.TopDown;
            messages.Location = new Point(334, 104);
            messages.Name = "messages";
            messages.Size = new Size(423, 335);
            messages.TabIndex = 10;
            messages.WrapContents = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(141, 445);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(579, 28);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            richTextBox1.KeyDown += richTextBox1_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(726, 445);
            button1.Name = "button1";
            button1.Size = new Size(31, 28);
            button1.TabIndex = 12;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // shopping
            // 
            shopping.BackgroundImageLayout = ImageLayout.Stretch;
            shopping.Location = new Point(3, 191);
            shopping.Name = "shopping";
            shopping.Size = new Size(126, 34);
            shopping.TabIndex = 18;
            shopping.Text = "Shopping";
            shopping.UseVisualStyleBackColor = true;
            shopping.Click += shopping_Click;
            // 
            // items
            // 
            items.BackgroundImageLayout = ImageLayout.Stretch;
            items.Location = new Point(3, 162);
            items.Name = "items";
            items.Size = new Size(126, 34);
            items.TabIndex = 17;
            items.Text = "My Items";
            items.UseVisualStyleBackColor = true;
            items.Click += items_Click;
            // 
            // searchView
            // 
            searchView.BackgroundImageLayout = ImageLayout.Stretch;
            searchView.Location = new Point(3, 133);
            searchView.Name = "searchView";
            searchView.Size = new Size(126, 34);
            searchView.TabIndex = 15;
            searchView.Text = "Search";
            searchView.UseVisualStyleBackColor = true;
            searchView.Click += searchView_Click;
            // 
            // userView
            // 
            userView.BackgroundImageLayout = ImageLayout.Stretch;
            userView.Location = new Point(3, 104);
            userView.Name = "userView";
            userView.Size = new Size(126, 34);
            userView.TabIndex = 14;
            userView.Text = "Account";
            userView.UseVisualStyleBackColor = true;
            userView.Click += userView_Click;
            // 
            // logout
            // 
            logout.BackgroundImageLayout = ImageLayout.Stretch;
            logout.Location = new Point(3, 250);
            logout.Name = "logout";
            logout.Size = new Size(126, 34);
            logout.TabIndex = 13;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // messageScreen
            // 
            messageScreen.BackgroundImageLayout = ImageLayout.Stretch;
            messageScreen.Location = new Point(3, 221);
            messageScreen.Name = "messageScreen";
            messageScreen.Size = new Size(126, 34);
            messageScreen.TabIndex = 19;
            messageScreen.Text = "Messages";
            messageScreen.UseVisualStyleBackColor = true;
            // 
            // messages_screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(messageScreen);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(messages);
            Controls.Add(shopping);
            Controls.Add(items);
            Controls.Add(searchView);
            Controls.Add(userView);
            Controls.Add(logout);
            Controls.Add(label1);
            Controls.Add(conversations_cont);
            Name = "messages_screen";
            Size = new Size(805, 534);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel conversations_cont;
        private FlowLayoutPanel messages;
        private RichTextBox richTextBox1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button shopping;
        private Button items;
        private Button searchView;
        private Button userView;
        private Button logout;
        private Button messageScreen;
    }
}
