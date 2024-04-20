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
            label1 = new Label();
            IbITotal = new Label();
            dataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // shopping
            // 
            shopping.BackgroundImageLayout = ImageLayout.Stretch;
            shopping.Location = new Point(4, 318);
            shopping.Margin = new Padding(4, 5, 4, 5);
            shopping.Name = "shopping";
            shopping.Size = new Size(180, 57);
            shopping.TabIndex = 17;
            shopping.Text = "Shopping";
            shopping.UseVisualStyleBackColor = true;
            shopping.Click += shopping_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(186, 173);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(900, 630);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // items
            // 
            items.BackgroundImageLayout = ImageLayout.Stretch;
            items.Location = new Point(4, 270);
            items.Margin = new Padding(4, 5, 4, 5);
            items.Name = "items";
            items.Size = new Size(180, 57);
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
            title.Location = new Point(186, 73);
            title.Margin = new Padding(4, 0, 4, 0);
            title.Name = "title";
            title.Size = new Size(131, 48);
            title.TabIndex = 14;
            title.Text = "Search";
            // 
            // messageScreen
            // 
            messageScreen.BackgroundImageLayout = ImageLayout.Stretch;
            messageScreen.Location = new Point(4, 368);
            messageScreen.Margin = new Padding(4, 5, 4, 5);
            messageScreen.Name = "messageScreen";
            messageScreen.Size = new Size(180, 57);
            messageScreen.TabIndex = 13;
            messageScreen.Text = "Messages";
            messageScreen.UseVisualStyleBackColor = true;
            messageScreen.Click += messageScreen_Click;
            // 
            // searchView
            // 
            searchView.BackgroundImageLayout = ImageLayout.Stretch;
            searchView.Location = new Point(4, 222);
            searchView.Margin = new Padding(4, 5, 4, 5);
            searchView.Name = "searchView";
            searchView.Size = new Size(180, 57);
            searchView.TabIndex = 12;
            searchView.Text = "Search";
            searchView.UseVisualStyleBackColor = true;
            // 
            // userView
            // 
            userView.BackgroundImageLayout = ImageLayout.Stretch;
            userView.Location = new Point(4, 173);
            userView.Margin = new Padding(4, 5, 4, 5);
            userView.Name = "userView";
            userView.Size = new Size(180, 57);
            userView.TabIndex = 11;
            userView.Text = "Account";
            userView.UseVisualStyleBackColor = true;
            userView.Click += userView_Click;
            // 
            // logout
            // 
            logout.BackgroundImageLayout = ImageLayout.Stretch;
            logout.Location = new Point(4, 417);
            logout.Margin = new Padding(4, 5, 4, 5);
            logout.Name = "logout";
            logout.Size = new Size(180, 57);
            logout.TabIndex = 10;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(287, 183);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter item name";
            txtSearch.Size = new Size(665, 39);
            txtSearch.TabIndex = 18;
            txtSearch.Text = "\r\n";
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // sButton
            // 
            sButton.FlatAppearance.BorderSize = 0;
            sButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sButton.Location = new Point(959, 183);
            sButton.Name = "sButton";
            sButton.Size = new Size(111, 48);
            sButton.TabIndex = 19;
            sButton.Text = "Search";
            sButton.UseVisualStyleBackColor = true;
            sButton.Click += sButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(191, 183);
            label1.Name = "label1";
            label1.Size = new Size(90, 32);
            label1.TabIndex = 21;
            label1.Text = "Search:";
            // 
            // IbITotal
            // 
            IbITotal.AutoSize = true;
            IbITotal.BackColor = SystemColors.ButtonHighlight;
            IbITotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IbITotal.Location = new Point(191, 737);
            IbITotal.Name = "IbITotal";
            IbITotal.Size = new Size(200, 32);
            IbITotal.TabIndex = 22;
            IbITotal.Text = "Total Records: ???";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(186, 237);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(900, 488);
            dataGridView.TabIndex = 20;
            // 
            // search_view
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(sButton);
            Controls.Add(IbITotal);
            Controls.Add(label1);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "search_view";
            Size = new Size(1150, 890);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
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
        private Label label1;
        private Label IbITotal;
        private DataGridView dataGridView;
    }
}
