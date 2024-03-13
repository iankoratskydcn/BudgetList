namespace BudgetGui.Screens
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
            home = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // home
            // 
            home.Location = new Point(363, 308);
            home.Name = "home";
            home.Size = new Size(75, 23);
            home.TabIndex = 0;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(348, 167);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 1;
            label1.Text = "Account";
            // 
            // user_view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(home);
            Name = "user_view";
            Size = new Size(805, 534);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button home;
        private Label label1;
    }
}
