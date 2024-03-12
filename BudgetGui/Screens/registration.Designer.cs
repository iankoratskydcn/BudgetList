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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox5 = new TextBox();
            loginHere = new LinkLabel();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 209);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Last Name";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(146, 238);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Email";
            textBox2.Size = new Size(253, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(146, 267);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Password";
            textBox3.Size = new Size(253, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(146, 296);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Repeat Your Password";
            textBox4.Size = new Size(253, 23);
            textBox4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(146, 356);
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
            label1.Location = new Point(166, 107);
            label1.Name = "label1";
            label1.Size = new Size(213, 37);
            label1.TabIndex = 5;
            label1.Text = "Create Account";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(146, 180);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "First Name";
            textBox5.Size = new Size(253, 23);
            textBox5.TabIndex = 6;
            // 
            // loginHere
            // 
            loginHere.ActiveLinkColor = Color.Black;
            loginHere.AutoSize = true;
            loginHere.LinkColor = Color.Black;
            loginHere.Location = new Point(305, 394);
            loginHere.Name = "loginHere";
            loginHere.Size = new Size(65, 15);
            loginHere.TabIndex = 7;
            loginHere.TabStop = true;
            loginHere.Text = "Login Here";
            loginHere.VisitedLinkColor = Color.Black;
            loginHere.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 394);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 8;
            label2.Text = "Already have an account?";
            // 
            // registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label2);
            Controls.Add(loginHere);
            Controls.Add(textBox5);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "registration";
            Size = new Size(548, 512);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label1;
        private TextBox textBox5;
        private LinkLabel loginHere;
        private Label label2;
    }
}
