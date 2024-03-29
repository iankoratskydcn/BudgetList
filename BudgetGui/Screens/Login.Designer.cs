namespace BudgetGui.Screens
{
    partial class Login
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
            textBox1 = new TextBox();
            register = new LinkLabel();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.OutlineButton;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(139, 342);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 18;
            label2.Text = "Not registered?";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(93, 225);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(253, 23);
            textBox1.TabIndex = 19;
            // 
            // register
            // 
            register.ActiveLinkColor = SystemColors.Highlight;
            register.AutoSize = true;
            register.BackColor = Color.Transparent;
            register.LinkColor = Color.Black;
            register.Location = new Point(222, 342);
            register.Name = "register";
            register.Size = new Size(77, 15);
            register.TabIndex = 17;
            register.TabStop = true;
            register.Text = "Register Here";
            register.VisitedLinkColor = Color.Black;
            register.LinkClicked += register_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(176, 151);
            label1.Name = "label1";
            label1.Size = new Size(89, 37);
            label1.TabIndex = 15;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(93, 316);
            button1.Name = "button1";
            button1.Size = new Size(253, 23);
            button1.TabIndex = 14;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(93, 254);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(253, 23);
            textBox2.TabIndex = 12;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(register);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Name = "Login";
            Size = new Size(805, 534);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private LinkLabel register;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
    }
}
