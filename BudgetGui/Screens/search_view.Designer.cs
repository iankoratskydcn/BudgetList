namespace BudgetGui.Screens
{
    partial class search_view
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search_view));
            shopping = new Button();
            pictureBox1 = new PictureBox();
            items = new Button();
            title = new Label();
            messageScreen = new Button();
            searchView = new Button();
            userView = new Button();
            logout = new Button();
            txtSearch = new TextBox();
            sButton = new Button();
            dataGridView = new DataGridView();
            pictureBox2 = new PictureBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // shopping
            // 
            shopping.BackgroundImageLayout = ImageLayout.Stretch;
            shopping.Location = new Point(3, 191);
            shopping.Name = "shopping";
            shopping.Size = new Size(126, 34);
            shopping.TabIndex = 17;
            shopping.Text = "Shopping";
            shopping.UseVisualStyleBackColor = true;
            shopping.Click += shopping_Click;
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
            // items
            // 
            items.BackgroundImageLayout = ImageLayout.Stretch;
            items.Location = new Point(3, 162);
            items.Name = "items";
            items.Size = new Size(126, 34);
            items.TabIndex = 15;
            items.Text = "My Items";
            items.UseVisualStyleBackColor = true;
            items.Click += items_Click;
            // 
            // title
            // 
            title.AutoSize = true;
            title.BackColor = Color.Transparent;
            title.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            title.ForeColor = Color.Black;
            title.Location = new Point(130, 44);
            title.Name = "title";
            title.Size = new Size(89, 32);
            title.TabIndex = 14;
            title.Text = "Search";
            // 
            // messageScreen
            // 
            messageScreen.BackgroundImageLayout = ImageLayout.Stretch;
            messageScreen.Location = new Point(3, 221);
            messageScreen.Name = "messageScreen";
            messageScreen.Size = new Size(126, 34);
            messageScreen.TabIndex = 13;
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
            searchView.TabIndex = 12;
            searchView.Text = "Search";
            searchView.UseVisualStyleBackColor = true;
            // 
            // userView
            // 
            userView.BackgroundImageLayout = ImageLayout.Stretch;
            userView.Location = new Point(3, 104);
            userView.Name = "userView";
            userView.Size = new Size(126, 34);
            userView.TabIndex = 11;
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
            logout.TabIndex = 10;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(146, 124);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter item name";
            txtSearch.Size = new Size(338, 29);
            txtSearch.TabIndex = 18;
            txtSearch.Text = "\r\n";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // sButton
            // 
            sButton.FlatAppearance.BorderSize = 0;
            sButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sButton.Location = new Point(488, 124);
            sButton.Margin = new Padding(2);
            sButton.Name = "sButton";
            sButton.Size = new Size(78, 29);
            sButton.TabIndex = 19;
            sButton.Text = "Search";
            sButton.UseVisualStyleBackColor = true;
            sButton.Click += sButton_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(146, 157);
            dataGridView.Margin = new Padding(2);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(420, 214);
            dataGridView.TabIndex = 20;
            dataGridView.CellClick += dataGridView_CellContentClick;
            dataGridView.CellContentClick += dataGridView_CellContentClick_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(588, 124);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(157, 148);
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(146, 392);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(599, 78);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(588, 288);
            button1.Name = "button1";
            button1.Size = new Size(157, 23);
            button1.TabIndex = 25;
            button1.Text = "Buy: $0";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(588, 319);
            button2.Name = "button2";
            button2.Size = new Size(157, 23);
            button2.TabIndex = 26;
            button2.Text = "Save Item";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(588, 348);
            button3.Name = "button3";
            button3.Size = new Size(157, 23);
            button3.TabIndex = 27;
            button3.Text = "Message Seller";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // search_view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox2);
            Controls.Add(sButton);
            Controls.Add(dataGridView);
            Controls.Add(txtSearch);
            Controls.Add(shopping);
            Controls.Add(items);
            Controls.Add(title);
            Controls.Add(messageScreen);
            Controls.Add(searchView);
            Controls.Add(userView);
            Controls.Add(logout);
            Controls.Add(pictureBox1);
            Name = "search_view";
            Size = new Size(805, 534);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button shopping;
        private PictureBox pictureBox1;
        private Button items;
        private Label title;
        private Button messageScreen;
        private Button searchView;
        private Button userView;
        private Button logout;
        private TextBox txtSearch;
        private Button sButton;
        private DataGridView dataGridView;
        private PictureBox pictureBox2;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
