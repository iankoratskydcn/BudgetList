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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(items_view));
            pictureBox1 = new PictureBox();
            items = new Button();
            title = new Label();
            messageScreen = new Button();
            searchView = new Button();
            userView = new Button();
            logout = new Button();
            myItems = new ListBox();
            soldItems = new ListBox();
            shopping = new Button();
            tabControl1 = new TabControl();
            tabPag1 = new TabPage();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            button1 = new Button();
            itemTitle = new TextBox();
            button2 = new Button();
            itemPrice = new TextBox();
            itemDesc = new TextBox();
            tabPage2 = new TabPage();
            button3 = new Button();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
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
            // myItems
            // 
            myItems.FormattingEnabled = true;
            myItems.ItemHeight = 15;
            myItems.Location = new Point(28, 13);
            myItems.Name = "myItems";
            myItems.Size = new Size(253, 274);
            myItems.TabIndex = 23;
            // 
            // soldItems
            // 
            soldItems.FormattingEnabled = true;
            soldItems.ItemHeight = 15;
            soldItems.Location = new Point(28, 13);
            soldItems.Name = "soldItems";
            soldItems.Size = new Size(253, 304);
            soldItems.TabIndex = 24;
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
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPag1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(135, 116);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(615, 356);
            tabControl1.TabIndex = 31;
            // 
            // tabPag1
            // 
            tabPag1.BackColor = Color.White;
            tabPag1.Controls.Add(button6);
            tabPag1.Controls.Add(button5);
            tabPag1.Controls.Add(pictureBox2);
            tabPag1.Controls.Add(textBox1);
            tabPag1.Controls.Add(button1);
            tabPag1.Controls.Add(itemTitle);
            tabPag1.Controls.Add(button2);
            tabPag1.Controls.Add(itemPrice);
            tabPag1.Controls.Add(itemDesc);
            tabPag1.Controls.Add(myItems);
            tabPag1.Location = new Point(4, 27);
            tabPag1.Name = "tabPag1";
            tabPag1.Padding = new Padding(3);
            tabPag1.Size = new Size(607, 325);
            tabPag1.TabIndex = 0;
            tabPag1.Text = "My Items";
            // 
            // button5
            // 
            button5.Location = new Point(65, 293);
            button5.Name = "button5";
            button5.Size = new Size(171, 23);
            button5.TabIndex = 55;
            button5.Text = "Create Item";
            button5.UseVisualStyleBackColor = true;
            button5.Click += createItem_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(361, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 165);
            pictureBox2.TabIndex = 54;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(319, 264);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Image Path";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(173, 23);
            textBox1.TabIndex = 53;
            // 
            // button1
            // 
            button1.Location = new Point(498, 264);
            button1.Name = "button1";
            button1.Size = new Size(74, 23);
            button1.TabIndex = 52;
            button1.Text = "Open File";
            button1.UseVisualStyleBackColor = true;
            // 
            // itemTitle
            // 
            itemTitle.Location = new Point(319, 177);
            itemTitle.Name = "itemTitle";
            itemTitle.PlaceholderText = "Title";
            itemTitle.Size = new Size(253, 23);
            itemTitle.TabIndex = 51;
            // 
            // button2
            // 
            button2.Location = new Point(319, 293);
            button2.Name = "button2";
            button2.Size = new Size(119, 23);
            button2.TabIndex = 50;
            button2.Text = "Edit Item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += submit_edited_item;
            // 
            // itemPrice
            // 
            itemPrice.Location = new Point(319, 235);
            itemPrice.Name = "itemPrice";
            itemPrice.PlaceholderText = "Price";
            itemPrice.Size = new Size(253, 23);
            itemPrice.TabIndex = 49;
            // 
            // itemDesc
            // 
            itemDesc.Location = new Point(319, 206);
            itemDesc.Name = "itemDesc";
            itemDesc.PlaceholderText = "Description";
            itemDesc.Size = new Size(253, 23);
            itemDesc.TabIndex = 48;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(pictureBox3);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(soldItems);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(607, 325);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sold";
            // 
            // button3
            // 
            button3.Location = new Point(452, 293);
            button3.Name = "button3";
            button3.Size = new Size(120, 23);
            button3.TabIndex = 62;
            button3.Text = "Message Buyer";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(361, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(165, 165);
            pictureBox3.TabIndex = 61;
            pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(319, 264);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Image Path";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(253, 23);
            textBox2.TabIndex = 60;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(319, 177);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Title";
            textBox3.Size = new Size(253, 23);
            textBox3.TabIndex = 58;
            // 
            // button4
            // 
            button4.Location = new Point(319, 293);
            button4.Name = "button4";
            button4.Size = new Size(120, 23);
            button4.TabIndex = 57;
            button4.Text = "List Duplicate";
            button4.UseVisualStyleBackColor = true;
            button4.Click += duplicate_item;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(319, 235);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Price";
            textBox4.Size = new Size(253, 23);
            textBox4.TabIndex = 56;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(319, 206);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Description";
            textBox5.Size = new Size(253, 23);
            textBox5.TabIndex = 55;
            // 
            // button6
            // 
            button6.Location = new Point(453, 293);
            button6.Name = "button6";
            button6.Size = new Size(119, 23);
            button6.TabIndex = 56;
            button6.Text = "Delete";
            button6.UseVisualStyleBackColor = true;
            // 
            // items_view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabControl1);
            Controls.Add(shopping);
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
            tabControl1.ResumeLayout(false);
            tabPag1.ResumeLayout(false);
            tabPag1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private ListBox myItems;
        private ListBox soldItems;
        private Button shopping;
        private TabControl tabControl1;
        private TabPage tabPag1;
        private TabPage tabPage2;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Button button1;
        private TextBox itemTitle;
        private Button button2;
        private TextBox itemPrice;
        private TextBox itemDesc;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button4;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button5;
        private Button button3;
        private Button button6;
    }
}
