namespace BudgetGui.Screens
{
    partial class items_view
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
            pictureBox1 = new PictureBox();
            items = new Button();
            title = new Label();
            messageScreen = new Button();
            searchView = new Button();
            userView = new Button();
            logout = new Button();
            testButton = new Button();
            myItems = new ListBox();
            soldItems = new ListBox();
            label1 = new Label();
            label2 = new Label();
            shopping = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            createItem = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(130, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 378);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // items
            // 
            items.BackgroundImageLayout = ImageLayout.Stretch;
            items.Location = new Point(3, 162);
            items.Name = "items";
            items.Size = new Size(126, 34);
            items.TabIndex = 14;
            items.Text = "My Items";
            items.UseVisualStyleBackColor = true;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.Black;
            title.Location = new Point(130, 44);
            title.Name = "title";
            title.Size = new Size(77, 32);
            title.TabIndex = 13;
            title.Text = "Items";
            // 
            // messageScreen
            // 
            messageScreen.BackgroundImageLayout = ImageLayout.Stretch;
            messageScreen.Location = new Point(3, 221);
            messageScreen.Name = "messageScreen";
            messageScreen.Size = new Size(126, 34);
            messageScreen.TabIndex = 12;
            messageScreen.Text = "Messages";
            messageScreen.UseVisualStyleBackColor = true;
            messageScreen.Click += messageScreen_Click;
            // 
            // searchView
            // 
            searchView.BackgroundImageLayout = ImageLayout.Stretch;
            searchView.Location = new Point(3, 133);
            searchView.Name = "searchView";
            searchView.Size = new Size(126, 34);
            searchView.TabIndex = 11;
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
            userView.TabIndex = 10;
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
            logout.TabIndex = 9;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // testButton
            // 
            testButton.Location = new Point(522, 64);
            testButton.Name = "testButton";
            testButton.Size = new Size(104, 23);
            testButton.TabIndex = 17;
            testButton.Text = "Create Fake Item";
            testButton.UseVisualStyleBackColor = true;
            testButton.Click += testButton_Click;
            // 
            // myItems
            // 
            myItems.FormattingEnabled = true;
            myItems.ItemHeight = 15;
            myItems.Location = new Point(130, 162);
            myItems.Name = "myItems";
            myItems.Size = new Size(316, 319);
            myItems.TabIndex = 23;
            // 
            // soldItems
            // 
            soldItems.FormattingEnabled = true;
            soldItems.ItemHeight = 15;
            soldItems.Location = new Point(444, 162);
            soldItems.Name = "soldItems";
            soldItems.Size = new Size(316, 319);
            soldItems.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(225, 133);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 25;
            label1.Text = "My Items";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(568, 133);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 26;
            label2.Text = "Sold Items";
            // 
            // shopping
            // 
            shopping.BackgroundImageLayout = ImageLayout.Stretch;
            shopping.Location = new Point(3, 191);
            shopping.Name = "shopping";
            shopping.Size = new Size(126, 34);
            shopping.TabIndex = 27;
            shopping.Text = "Shopping";
            shopping.UseVisualStyleBackColor = true;
            shopping.Click += shopping_Click;
            // 
            // button1
            // 
            button1.Location = new Point(666, 64);
            button1.Name = "button1";
            button1.Size = new Size(70, 23);
            button1.TabIndex = 28;
            button1.Text = "Make Sold";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(666, 35);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "itemId";
            textBox1.Size = new Size(70, 23);
            textBox1.TabIndex = 29;
            // 
            // createItem
            // 
            createItem.Location = new Point(388, 114);
            createItem.Name = "createItem";
            createItem.Size = new Size(113, 42);
            createItem.TabIndex = 30;
            createItem.Text = "Create New Item";
            createItem.UseVisualStyleBackColor = true;
            createItem.Click += createItem_Click;
            // 
            // items_view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(createItem);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(shopping);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(soldItems);
            Controls.Add(myItems);
            Controls.Add(testButton);
            Controls.Add(pictureBox1);
            Controls.Add(items);
            Controls.Add(title);
            Controls.Add(messageScreen);
            Controls.Add(searchView);
            Controls.Add(userView);
            Controls.Add(logout);
            Name = "items_view";
            Size = new Size(805, 534);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button items;
        private Label title;
        private Button messageScreen;
        private Button searchView;
        private Button userView;
        private Button logout;
        private Button testButton;
        private ListBox myItems;
        private ListBox soldItems;
        private Label label1;
        private Label label2;
        private Button shopping;
        private Button button1;
        private TextBox textBox1;
        private Button createItem;
    }
}
