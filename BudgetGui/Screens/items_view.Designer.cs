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
            delete_button = new Button();
            create_item = new Button();
            my_pic = new PictureBox();
            myPic_path = new TextBox();
            my_pic_button = new Button();
            my_item = new TextBox();
            edit_button = new Button();
            my_price = new TextBox();
            my_desc = new TextBox();
            tabPage2 = new TabPage();
            message_buyer = new Button();
            sold_pic = new PictureBox();
            sold_pic_path = new TextBox();
            sold_title = new TextBox();
            sold_price = new TextBox();
            sold_desc = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPag1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)my_pic).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sold_pic).BeginInit();
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
            myItems.SelectedIndexChanged += myItems_SelectedIndexChanged;
            // 
            // soldItems
            // 
            soldItems.FormattingEnabled = true;
            soldItems.ItemHeight = 15;
            soldItems.Location = new Point(28, 13);
            soldItems.Name = "soldItems";
            soldItems.Size = new Size(253, 304);
            soldItems.TabIndex = 24;
            soldItems.SelectedIndexChanged += soldItems_SelectedIndexChanged;
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
            tabControl1.SelectedIndexChanged += soldItems_SelectedIndexChanged;
            // 
            // tabPag1
            // 
            tabPag1.BackColor = Color.White;
            tabPag1.Controls.Add(delete_button);
            tabPag1.Controls.Add(create_item);
            tabPag1.Controls.Add(my_pic);
            tabPag1.Controls.Add(myPic_path);
            tabPag1.Controls.Add(my_pic_button);
            tabPag1.Controls.Add(my_item);
            tabPag1.Controls.Add(edit_button);
            tabPag1.Controls.Add(my_price);
            tabPag1.Controls.Add(my_desc);
            tabPag1.Controls.Add(myItems);
            tabPag1.Location = new Point(4, 27);
            tabPag1.Name = "tabPag1";
            tabPag1.Padding = new Padding(3);
            tabPag1.Size = new Size(607, 325);
            tabPag1.TabIndex = 0;
            tabPag1.Text = "My Items";
            // 
            // delete_button
            // 
            delete_button.Location = new Point(453, 293);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(119, 23);
            delete_button.TabIndex = 56;
            delete_button.Text = "Delete";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // create_item
            // 
            create_item.Location = new Point(65, 293);
            create_item.Name = "create_item";
            create_item.Size = new Size(171, 23);
            create_item.TabIndex = 55;
            create_item.Text = "Create Item";
            create_item.UseVisualStyleBackColor = true;
            create_item.Click += createItem_Click;
            // 
            // my_pic
            // 
            my_pic.BackgroundImage = (Image)resources.GetObject("my_pic.BackgroundImage");
            my_pic.BackgroundImageLayout = ImageLayout.Stretch;
            my_pic.Location = new Point(361, 6);
            my_pic.Name = "my_pic";
            my_pic.Size = new Size(165, 165);
            my_pic.TabIndex = 54;
            my_pic.TabStop = false;
            // 
            // myPic_path
            // 
            myPic_path.Location = new Point(319, 264);
            myPic_path.Name = "myPic_path";
            myPic_path.PlaceholderText = "Image Path";
            myPic_path.ReadOnly = true;
            myPic_path.Size = new Size(173, 23);
            myPic_path.TabIndex = 53;
            // 
            // my_pic_button
            // 
            my_pic_button.Location = new Point(498, 264);
            my_pic_button.Name = "my_pic_button";
            my_pic_button.Size = new Size(74, 23);
            my_pic_button.TabIndex = 52;
            my_pic_button.Text = "Open File";
            my_pic_button.UseVisualStyleBackColor = true;
            my_pic_button.Click += my_pic_button_Click;
            // 
            // my_item
            // 
            my_item.Location = new Point(319, 177);
            my_item.Name = "my_item";
            my_item.PlaceholderText = "Title";
            my_item.Size = new Size(253, 23);
            my_item.TabIndex = 51;
            // 
            // edit_button
            // 
            edit_button.Location = new Point(319, 293);
            edit_button.Name = "edit_button";
            edit_button.Size = new Size(119, 23);
            edit_button.TabIndex = 50;
            edit_button.Text = "Save Edits";
            edit_button.UseVisualStyleBackColor = true;
            edit_button.Click += submit_edited_item;
            // 
            // my_price
            // 
            my_price.Location = new Point(319, 235);
            my_price.Name = "my_price";
            my_price.PlaceholderText = "Price";
            my_price.Size = new Size(253, 23);
            my_price.TabIndex = 49;
            // 
            // my_desc
            // 
            my_desc.Location = new Point(319, 206);
            my_desc.Name = "my_desc";
            my_desc.PlaceholderText = "Description";
            my_desc.Size = new Size(253, 23);
            my_desc.TabIndex = 48;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(message_buyer);
            tabPage2.Controls.Add(sold_pic);
            tabPage2.Controls.Add(sold_pic_path);
            tabPage2.Controls.Add(sold_title);
            tabPage2.Controls.Add(sold_price);
            tabPage2.Controls.Add(sold_desc);
            tabPage2.Controls.Add(soldItems);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(607, 325);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Sold";
            // 
            // message_buyer
            // 
            message_buyer.Location = new Point(380, 293);
            message_buyer.Name = "message_buyer";
            message_buyer.Size = new Size(120, 23);
            message_buyer.TabIndex = 62;
            message_buyer.Text = "Message Buyer";
            message_buyer.UseVisualStyleBackColor = true;
            message_buyer.Click += message_buyer_Click;
            // 
            // sold_pic
            // 
            sold_pic.BackgroundImage = (Image)resources.GetObject("sold_pic.BackgroundImage");
            sold_pic.BackgroundImageLayout = ImageLayout.Stretch;
            sold_pic.Location = new Point(361, 6);
            sold_pic.Name = "sold_pic";
            sold_pic.Size = new Size(165, 165);
            sold_pic.TabIndex = 61;
            sold_pic.TabStop = false;
            // 
            // sold_pic_path
            // 
            sold_pic_path.Location = new Point(319, 264);
            sold_pic_path.Name = "sold_pic_path";
            sold_pic_path.PlaceholderText = "Image Path";
            sold_pic_path.ReadOnly = true;
            sold_pic_path.Size = new Size(253, 23);
            sold_pic_path.TabIndex = 60;
            // 
            // sold_title
            // 
            sold_title.Location = new Point(319, 177);
            sold_title.Name = "sold_title";
            sold_title.PlaceholderText = "Title";
            sold_title.Size = new Size(253, 23);
            sold_title.TabIndex = 58;
            // 
            // sold_price
            // 
            sold_price.Location = new Point(319, 235);
            sold_price.Name = "sold_price";
            sold_price.PlaceholderText = "Price";
            sold_price.Size = new Size(253, 23);
            sold_price.TabIndex = 56;
            // 
            // sold_desc
            // 
            sold_desc.Location = new Point(319, 206);
            sold_desc.Name = "sold_desc";
            sold_desc.PlaceholderText = "Description";
            sold_desc.Size = new Size(253, 23);
            sold_desc.TabIndex = 55;
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
            ((System.ComponentModel.ISupportInitialize)my_pic).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sold_pic).EndInit();
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
        private PictureBox my_pic;
        private TextBox myPic_path;
        private Button my_pic_button;
        private TextBox my_item;
        private Button edit_button;
        private TextBox my_price;
        private TextBox my_desc;
        private PictureBox sold_pic;
        private TextBox sold_pic_path;
        private TextBox sold_title;
        private TextBox sold_price;
        private TextBox sold_desc;
        private Button create_item;
        private Button message_buyer;
        private Button delete_button;
    }
}
