namespace BudgetGui.Screens
{
    partial class shopping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shopping));
            title = new Label();
            button1 = new Button();
            items = new Button();
            messageScreen = new Button();
            searchView = new Button();
            userView = new Button();
            logout = new Button();
            pictureBox1 = new PictureBox();
            boughtItems = new ListBox();
            savedItems = new ListBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            saved_Title = new TextBox();
            saved_Desc = new RichTextBox();
            saved_pic = new PictureBox();
            tabPage2 = new TabPage();
            button5 = new Button();
            bought_title = new TextBox();
            bought_desc = new RichTextBox();
            bought_pic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)saved_pic).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bought_pic).BeginInit();
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
            title.Size = new Size(123, 32);
            title.TabIndex = 14;
            title.Text = "Shopping";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(3, 191);
            button1.Name = "button1";
            button1.Size = new Size(126, 34);
            button1.TabIndex = 33;
            button1.Text = "Shopping";
            button1.UseVisualStyleBackColor = true;
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
            // boughtItems
            // 
            boughtItems.FormattingEnabled = true;
            boughtItems.ItemHeight = 15;
            boughtItems.Location = new Point(6, 8);
            boughtItems.Name = "boughtItems";
            boughtItems.Size = new Size(157, 304);
            boughtItems.TabIndex = 37;
            boughtItems.SelectedIndexChanged += boughtItems_SelectedIndexChanged;
            // 
            // savedItems
            // 
            savedItems.FormattingEnabled = true;
            savedItems.ItemHeight = 15;
            savedItems.Location = new Point(6, 8);
            savedItems.Name = "savedItems";
            savedItems.Size = new Size(157, 304);
            savedItems.TabIndex = 36;
            savedItems.SelectedIndexChanged += savedItems_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(135, 119);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(616, 349);
            tabControl1.TabIndex = 38;
            tabControl1.SelectedIndexChanged += change_tab;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(saved_Title);
            tabPage1.Controls.Add(saved_Desc);
            tabPage1.Controls.Add(saved_pic);
            tabPage1.Controls.Add(savedItems);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(608, 318);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Saved Items";
            // 
            // button4
            // 
            button4.Location = new Point(445, 289);
            button4.Name = "button4";
            button4.Size = new Size(157, 23);
            button4.TabIndex = 47;
            button4.Text = "Remove";
            button4.UseVisualStyleBackColor = true;
            button4.Click += remove_Click;
            // 
            // button3
            // 
            button3.Location = new Point(445, 260);
            button3.Name = "button3";
            button3.Size = new Size(157, 23);
            button3.TabIndex = 46;
            button3.Text = "Message Seller";
            button3.UseVisualStyleBackColor = true;
            button3.Click += message_saved_Click;
            // 
            // button2
            // 
            button2.Location = new Point(445, 230);
            button2.Name = "button2";
            button2.Size = new Size(157, 23);
            button2.TabIndex = 45;
            button2.Text = "Buy for: $0";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buy_Click;
            // 
            // saved_Title
            // 
            saved_Title.Location = new Point(185, 12);
            saved_Title.Name = "saved_Title";
            saved_Title.Size = new Size(232, 23);
            saved_Title.TabIndex = 44;
            // 
            // saved_Desc
            // 
            saved_Desc.Location = new Point(445, 11);
            saved_Desc.Name = "saved_Desc";
            saved_Desc.Size = new Size(157, 210);
            saved_Desc.TabIndex = 43;
            saved_Desc.Text = "";
            // 
            // saved_pic
            // 
            saved_pic.Image = (Image)resources.GetObject("saved_pic.Image");
            saved_pic.Location = new Point(172, 43);
            saved_pic.Name = "saved_pic";
            saved_pic.Size = new Size(260, 260);
            saved_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            saved_pic.TabIndex = 42;
            saved_pic.TabStop = false;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(bought_title);
            tabPage2.Controls.Add(bought_desc);
            tabPage2.Controls.Add(bought_pic);
            tabPage2.Controls.Add(boughtItems);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(608, 318);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Purchase History";
            // 
            // button5
            // 
            button5.Location = new Point(242, 286);
            button5.Name = "button5";
            button5.Size = new Size(118, 23);
            button5.TabIndex = 42;
            button5.Text = "Message Seller";
            button5.UseVisualStyleBackColor = true;
            button5.Click += message_bought_Click;
            // 
            // bought_title
            // 
            bought_title.Location = new Point(185, 12);
            bought_title.Name = "bought_title";
            bought_title.Size = new Size(232, 23);
            bought_title.TabIndex = 41;
            // 
            // bought_desc
            // 
            bought_desc.Location = new Point(445, 11);
            bought_desc.Name = "bought_desc";
            bought_desc.Size = new Size(157, 301);
            bought_desc.TabIndex = 39;
            bought_desc.Text = "";
            // 
            // bought_pic
            // 
            bought_pic.ErrorImage = (Image)resources.GetObject("bought_pic.ErrorImage");
            bought_pic.Image = (Image)resources.GetObject("bought_pic.Image");
            bought_pic.Location = new Point(185, 48);
            bought_pic.Name = "bought_pic";
            bought_pic.Size = new Size(232, 232);
            bought_pic.SizeMode = PictureBoxSizeMode.StretchImage;
            bought_pic.TabIndex = 38;
            bought_pic.TabStop = false;
            // 
            // shopping
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tabControl1);
            Controls.Add(button1);
            Controls.Add(items);
            Controls.Add(messageScreen);
            Controls.Add(searchView);
            Controls.Add(userView);
            Controls.Add(logout);
            Controls.Add(pictureBox1);
            Controls.Add(title);
            Name = "shopping";
            Size = new Size(805, 534);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)saved_pic).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bought_pic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Button button1;
        private Button items;
        private Button messageScreen;
        private Button searchView;
        private Button userView;
        private Button logout;
        private PictureBox pictureBox1;
        private ListBox boughtItems;
        private ListBox savedItems;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private PictureBox bought_pic;
        private TextBox saved_Title;
        private RichTextBox saved_Desc;
        private PictureBox saved_pic;
        private TextBox bought_title;
        private RichTextBox bought_desc;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
    }
}
