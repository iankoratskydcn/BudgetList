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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            register = new Button();
            label3 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImage = (Image)resources.GetObject("tableLayoutPanel1.BackgroundImage");
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 286F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1150, 890);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 51F));
            tableLayoutPanel2.Controls.Add(button1, 2, 2);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel2.Controls.Add(textBox1, 0, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(label2, 1, 1);
            tableLayoutPanel2.Controls.Add(register, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(436, 283);
            tableLayoutPanel2.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(278, 323);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(230, 159);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(44, 37);
            button1.TabIndex = 0;
            button1.Text = ">";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(117, 159);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(105, 31);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(4, 159);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(105, 31);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Location = new Point(4, 129);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 3;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Bottom;
            label2.Location = new Point(117, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // register
            // 
            register.Location = new Point(4, 206);
            register.Margin = new Padding(4, 5, 4, 5);
            register.Name = "register";
            register.Size = new Size(104, 38);
            register.TabIndex = 5;
            register.Text = "Register";
            register.UseVisualStyleBackColor = true;
            register.Click += register_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(518, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(114, 48);
            label3.TabIndex = 1;
            label3.Text = "Login";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            Size = new Size(1150, 890);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Button register;
        private Label label3;
    }
}
