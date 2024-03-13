namespace BudgetGui.Screens
{
    partial class messages_screen
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
            viewConversation = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(342, 187);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 6;
            label1.Text = "Messages";
            // 
            // home
            // 
            home.Location = new Point(342, 326);
            home.Name = "home";
            home.Size = new Size(116, 23);
            home.TabIndex = 7;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // viewConversation
            // 
            viewConversation.Location = new Point(342, 297);
            viewConversation.Name = "viewConversation";
            viewConversation.Size = new Size(116, 23);
            viewConversation.TabIndex = 8;
            viewConversation.Text = "View Conversation";
            viewConversation.UseVisualStyleBackColor = true;
            viewConversation.Click += viewConversation_Click;
            // 
            // messages_screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(viewConversation);
            Controls.Add(home);
            Controls.Add(label1);
            Name = "messages_screen";
            Size = new Size(805, 534);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button home;
        private Button viewConversation;
    }
}
