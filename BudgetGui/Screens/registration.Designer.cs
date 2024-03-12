namespace BudgetGui.Screens
{
    partial class registration
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
            Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            lastName = new TextBox();
            email = new TextBox();
            password1 = new TextBox();
            password2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            firstName = new TextBox();
            loginHere = new LinkLabel();
            username = new TextBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 410);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 8;
            label2.Text = "Already have an account?";
            // 
            // lastName
            // 
            lastName.Location = new Point(91, 202);
            lastName.Name = "lastName";
            lastName.PlaceholderText = "Last Name";
            lastName.Size = new Size(253, 23);
            lastName.TabIndex = 0;
            // 
            // email
            // 
            email.Location = new Point(91, 231);
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(253, 23);
            email.TabIndex = 1;
            // 
            // password1
            // 
            password1.Location = new Point(91, 289);
            password1.Name = "password1";
            password1.PlaceholderText = "Password";
            password1.Size = new Size(253, 23);
            password1.TabIndex = 2;
            // 
            // password2
            // 
            password2.Location = new Point(91, 318);
            password2.Name = "password2";
            password2.PlaceholderText = "Repeat Your Password";
            password2.Size = new Size(253, 23);
            password2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(91, 384);
            button1.Name = "button1";
            button1.Size = new Size(253, 23);
            button1.TabIndex = 4;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(111, 100);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 5;
            label1.Text = "Create Account";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // firstName
            // 
            firstName.Location = new Point(91, 173);
            firstName.Name = "firstName";
            firstName.PlaceholderText = "First Name";
            firstName.Size = new Size(253, 23);
            firstName.TabIndex = 6;
            firstName.TextChanged += firstName_TextChanged;
            // 
            // loginHere
            // 
            loginHere.ActiveLinkColor = SystemColors.Highlight;
            loginHere.AutoSize = true;
            loginHere.LinkColor = Color.Black;
            loginHere.Location = new Point(250, 410);
            loginHere.Name = "loginHere";
            loginHere.Size = new Size(65, 15);
            loginHere.TabIndex = 7;
            loginHere.TabStop = true;
            loginHere.Text = "Login Here";
            loginHere.VisitedLinkColor = Color.Black;
            loginHere.LinkClicked += linkLabel1_LinkClicked;
            // 
            // username
            // 
            username.Location = new Point(91, 260);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(253, 23);
            username.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(805, 534);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(loginHere);
            Controls.Add(firstName);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(password2);
            Controls.Add(password1);
            Controls.Add(email);
            Controls.Add(lastName);
            Controls.Add(pictureBox1);
            Name = "registration";
            Size = new Size(805, 534);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox lastName;
        private TextBox email;
        private TextBox password1;
        private TextBox password2;
        private Button button1;
        private Label label1;
        private TextBox firstName;
        private LinkLabel loginHere;
        private Label label2;
        private TextBox username;
        private PictureBox pictureBox1;
    }
}
