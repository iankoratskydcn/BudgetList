namespace BudgetGui.Screens
{
    partial class create_item_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_item_screen));
            title = new Label();
            pictureBox1 = new PictureBox();
            shopping = new Button();
            items = new Button();
            messageScreen = new Button();
            searchView = new Button();
            userView = new Button();
            logout = new Button();
            itemTitle = new TextBox();
            createItem = new Button();
            itemPrice = new TextBox();
            itemDesc = new TextBox();
            label1 = new Label();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            title.TabIndex = 14;
            title.Text = "Items";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(130, 104);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(630, 378);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // shopping
            // 
            shopping.BackgroundImageLayout = ImageLayout.Stretch;
            shopping.Location = new Point(3, 191);
            shopping.Name = "shopping";
            shopping.Size = new Size(126, 34);
            shopping.TabIndex = 33;
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
            items.TabIndex = 32;
            items.Text = "My Items";
            items.UseVisualStyleBackColor = true;
            items.Click += items_Click;
            // 
            // messageScreen
            // 
            messageScreen.BackgroundImageLayout = ImageLayout.Stretch;
            messageScreen.Location = new Point(3, 221);
            messageScreen.Name = "messageScreen";
            messageScreen.Size = new Size(126, 34);
            messageScreen.TabIndex = 31;
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
            searchView.TabIndex = 30;
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
            userView.TabIndex = 29;
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
            logout.TabIndex = 28;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // itemTitle
            // 
            itemTitle.Location = new Point(456, 182);
            itemTitle.Name = "itemTitle";
            itemTitle.PlaceholderText = "Title";
            itemTitle.Size = new Size(253, 23);
            itemTitle.TabIndex = 39;
            // 
            // createItem
            // 
            createItem.Location = new Point(456, 298);
            createItem.Name = "createItem";
            createItem.Size = new Size(253, 23);
            createItem.TabIndex = 38;
            createItem.Text = "Create Item";
            createItem.UseVisualStyleBackColor = true;
            createItem.Click += createItem_Click;
            // 
            // itemPrice
            // 
            itemPrice.Location = new Point(456, 240);
            itemPrice.Name = "itemPrice";
            itemPrice.PlaceholderText = "Price";
            itemPrice.Size = new Size(253, 23);
            itemPrice.TabIndex = 35;
            itemPrice.TextChanged += itemPrice_TextChanged;
            // 
            // itemDesc
            // 
            itemDesc.Location = new Point(456, 211);
            itemDesc.Name = "itemDesc";
            itemDesc.PlaceholderText = "Description";
            itemDesc.Size = new Size(253, 23);
            itemDesc.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(396, 146);
            label1.Name = "label1";
            label1.Size = new Size(98, 21);
            label1.TabIndex = 41;
            label1.Text = "Create Item";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(635, 269);
            button1.Name = "button1";
            button1.Size = new Size(74, 23);
            button1.TabIndex = 42;
            button1.Text = "Open File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(456, 269);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Image Path";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 43;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(183, 182);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(250, 250);
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // create_item_screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(itemTitle);
            Controls.Add(createItem);
            Controls.Add(itemPrice);
            Controls.Add(itemDesc);
            Controls.Add(shopping);
            Controls.Add(items);
            Controls.Add(messageScreen);
            Controls.Add(searchView);
            Controls.Add(userView);
            Controls.Add(logout);
            Controls.Add(pictureBox1);
            Controls.Add(title);
            Name = "create_item_screen";
            Size = new Size(805, 534);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private PictureBox pictureBox1;
        private Button shopping;
        private Button items;
        private Button messageScreen;
        private Button searchView;
        private Button userView;
        private Button logout;
        private TextBox itemTitle;
        private Button createItem;
        private TextBox itemPrice;
        private TextBox itemDesc;
        private Label label1;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
    }
}
