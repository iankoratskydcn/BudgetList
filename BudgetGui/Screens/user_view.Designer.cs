﻿namespace BudgetGui.Screens
{
    partial class user_view
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
            city = new TextBox();
            dateOfBirth = new TextBox();
            save = new Button();
            zip = new TextBox();
            state = new TextBox();
            street = new TextBox();
            password = new TextBox();
            email = new TextBox();
            shopping = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            title.Size = new Size(109, 32);
            title.TabIndex = 13;
            title.Text = "Account";
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
            // city
            // 
            city.Location = new Point(318, 307);
            city.Name = "city";
            city.PlaceholderText = "City";
            city.Size = new Size(253, 23);
            city.TabIndex = 22;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Location = new Point(318, 249);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.PlaceholderText = "Date of Birth (yyyy-MM-dd)";
            dateOfBirth.Size = new Size(253, 23);
            dateOfBirth.TabIndex = 21;
            // 
            // save
            // 
            save.Location = new Point(318, 431);
            save.Name = "save";
            save.Size = new Size(253, 23);
            save.TabIndex = 20;
            save.Text = "Save";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // zip
            // 
            zip.Location = new Point(318, 365);
            zip.Name = "zip";
            zip.PlaceholderText = "Zip";
            zip.Size = new Size(253, 23);
            zip.TabIndex = 19;
            // 
            // state
            // 
            state.Location = new Point(318, 336);
            state.Name = "state";
            state.PlaceholderText = "State";
            state.Size = new Size(253, 23);
            state.TabIndex = 18;
            // 
            // street
            // 
            street.Location = new Point(318, 278);
            street.Name = "street";
            street.PlaceholderText = "Street";
            street.Size = new Size(253, 23);
            street.TabIndex = 17;
            // 
            // password
            // 
            password.Location = new Point(318, 220);
            password.Name = "password";
            password.PlaceholderText = "Password";
            password.Size = new Size(253, 23);
            password.TabIndex = 23;
            // 
            // email
            // 
            email.Location = new Point(318, 191);
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(253, 23);
            email.TabIndex = 24;
            // 
            // shopping
            // 
            shopping.BackgroundImageLayout = ImageLayout.Stretch;
            shopping.Location = new Point(3, 191);
            shopping.Name = "shopping";
            shopping.Size = new Size(126, 34);
            shopping.TabIndex = 28;
            shopping.Text = "Shopping";
            shopping.UseVisualStyleBackColor = true;
            shopping.Click += shopping_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(343, 133);
            label2.Name = "label2";
            label2.Size = new Size(203, 21);
            label2.TabIndex = 42;
            label2.Text = "Edit Account Information";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // user_view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(shopping);
            Controls.Add(email);
            Controls.Add(password);
            Controls.Add(city);
            Controls.Add(dateOfBirth);
            Controls.Add(save);
            Controls.Add(zip);
            Controls.Add(state);
            Controls.Add(street);
            Controls.Add(pictureBox1);
            Controls.Add(items);
            Controls.Add(title);
            Controls.Add(messageScreen);
            Controls.Add(searchView);
            Controls.Add(userView);
            Controls.Add(logout);
            Name = "user_view";
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
        private TextBox city;
        private TextBox dateOfBirth;
        private Button save;
        private TextBox zip;
        private TextBox state;
        private TextBox street;
        private TextBox password;
        private TextBox email;
        private Button shopping;
        private Label label2;
    }
}
