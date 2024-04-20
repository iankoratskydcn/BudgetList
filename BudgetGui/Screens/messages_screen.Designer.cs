namespace BudgetGui.Screens
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
            label1 = new Label();
            conversations = new FlowLayoutPanel();
            messages = new FlowLayoutPanel();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            shopping = new Button();
            items = new Button();
            messageScreen = new Button();
            searchView = new Button();
            userView = new Button();
            logout = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // conversations
            // 
            conversations.BackgroundImageLayout = ImageLayout.Stretch;
            conversations.FlowDirection = FlowDirection.TopDown;
            conversations.Location = new Point(141, 116);
            conversations.Name = "conversations";
            conversations.Size = new Size(187, 319);
            conversations.TabIndex = 9;
            // 
            // messages
            // 
            messages.AutoScroll = true;
            messages.FlowDirection = FlowDirection.TopDown;
            messages.Location = new Point(334, 116);
            messages.Name = "messages";
            messages.Size = new Size(423, 319);
            messages.TabIndex = 10;
            messages.WrapContents = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(141, 445);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(585, 28);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            richTextBox1.Enter += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(732, 445);
            button1.Name = "button1";
            button1.Size = new Size(25, 28);
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
            shopping.Location = new Point(3, 192);
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
            items.Location = new Point(3, 163);
            items.Name = "items";
            items.Size = new Size(126, 34);
            items.TabIndex = 17;
            items.Text = "My Items";
            items.UseVisualStyleBackColor = true;
            items.Click += items_Click;
            // 
            // messageScreen
            // 
            messageScreen.BackgroundImageLayout = ImageLayout.Stretch;
            messageScreen.Location = new Point(3, 222);
            messageScreen.Name = "messageScreen";
            messageScreen.Size = new Size(126, 34);
            messageScreen.TabIndex = 16;
            messageScreen.Text = "Messages";
            messageScreen.UseVisualStyleBackColor = true;
            messageScreen.Click += messageScreen_Click;
            // 
            // searchView
            // 
            searchView.BackgroundImageLayout = ImageLayout.Stretch;
            searchView.Location = new Point(3, 134);
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
            logout.Location = new Point(3, 251);
            logout.Name = "logout";
            logout.Size = new Size(126, 34);
            logout.TabIndex = 13;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(135, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 378);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // messages_screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(messages);
            Controls.Add(conversations);
            Controls.Add(pictureBox1);
            Controls.Add(shopping);
            Controls.Add(items);
            Controls.Add(messageScreen);
            Controls.Add(searchView);
            Controls.Add(userView);
            Controls.Add(logout);
            Controls.Add(label1);
            Name = "messages_screen";
            Size = new Size(805, 534);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel conversations;
        private FlowLayoutPanel messages;
        private RichTextBox richTextBox1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button shopping;
        private Button items;
        private Button messageScreen;
        private Button searchView;
        private Button userView;
        private Button logout;
        private PictureBox pictureBox1;
    }
}
