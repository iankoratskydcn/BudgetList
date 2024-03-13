namespace BudgetGui.Screens
{
    partial class items_view
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
            label1 = new Label();
            home = new Button();
            viewItem = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(355, 181);
            label1.Name = "label1";
            label1.Size = new Size(120, 32);
            label1.TabIndex = 0;
            label1.Text = "My Items";
            // 
            // home
            // 
            home.Location = new Point(370, 321);
            home.Name = "home";
            home.Size = new Size(75, 23);
            home.TabIndex = 1;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // viewItem
            // 
            viewItem.Location = new Point(370, 292);
            viewItem.Name = "viewItem";
            viewItem.Size = new Size(75, 23);
            viewItem.TabIndex = 2;
            viewItem.Text = "View Item";
            viewItem.UseVisualStyleBackColor = true;
            viewItem.Click += viewItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 300);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "Can't come back yet";
            // 
            // items_view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(viewItem);
            Controls.Add(home);
            Controls.Add(label1);
            Name = "items_view";
            Size = new Size(805, 534);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button home;
        private Button viewItem;
        private Label label2;
    }
}
