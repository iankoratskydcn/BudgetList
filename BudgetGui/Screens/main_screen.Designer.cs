namespace BudgetGui.Screens
{
    partial class main_screen
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
            logout = new Button();
            userView = new Button();
            searchView = new Button();
            messageScreen = new Button();
            label1 = new Label();
            items = new Button();
            SuspendLayout();
            // 
            // logout
            // 
            logout.Location = new Point(362, 318);
            logout.Name = "logout";
            logout.Size = new Size(75, 23);
            logout.TabIndex = 1;
            logout.Text = "Logout";
            logout.UseVisualStyleBackColor = true;
            logout.Click += logout_Click;
            // 
            // userView
            // 
            userView.Location = new Point(240, 238);
            userView.Name = "userView";
            userView.Size = new Size(75, 23);
            userView.TabIndex = 2;
            userView.Text = "Account";
            userView.UseVisualStyleBackColor = true;
            userView.Click += userView_Click;
            // 
            // searchView
            // 
            searchView.Location = new Point(321, 238);
            searchView.Name = "searchView";
            searchView.Size = new Size(75, 23);
            searchView.TabIndex = 3;
            searchView.Text = "Search";
            searchView.UseVisualStyleBackColor = true;
            searchView.Click += searchView_Click;
            // 
            // messageScreen
            // 
            messageScreen.Location = new Point(483, 238);
            messageScreen.Name = "messageScreen";
            messageScreen.Size = new Size(75, 23);
            messageScreen.TabIndex = 4;
            messageScreen.Text = "Messages";
            messageScreen.UseVisualStyleBackColor = true;
            messageScreen.Click += messageScreen_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(328, 156);
            label1.Name = "label1";
            label1.Size = new Size(145, 32);
            label1.TabIndex = 5;
            label1.Text = "Main Menu";
            // 
            // items
            // 
            items.Location = new Point(402, 238);
            items.Name = "items";
            items.Size = new Size(75, 23);
            items.TabIndex = 6;
            items.Text = "My Items";
            items.UseVisualStyleBackColor = true;
            items.Click += items_Click;
            // 
            // main_screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(items);
            Controls.Add(label1);
            Controls.Add(messageScreen);
            Controls.Add(searchView);
            Controls.Add(userView);
            Controls.Add(logout);
            Name = "main_screen";
            Size = new Size(805, 534);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button logout;
        private Button userView;
        private Button searchView;
        private Button messageScreen;
        private Label label1;
        private Button items;
    }
}
