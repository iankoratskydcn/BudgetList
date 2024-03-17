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
            conversations = new FlowLayoutPanel();
            messages = new FlowLayoutPanel();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 32);
            label1.TabIndex = 6;
            label1.Text = "Messages";
            // 
            // home
            // 
            home.Location = new Point(13, 507);
            home.Name = "home";
            home.Size = new Size(116, 23);
            home.TabIndex = 7;
            home.Text = "Home";
            home.UseVisualStyleBackColor = true;
            home.Click += home_Click;
            // 
            // viewConversation
            // 
            viewConversation.Location = new Point(211, 507);
            viewConversation.Name = "viewConversation";
            viewConversation.Size = new Size(116, 23);
            viewConversation.TabIndex = 8;
            viewConversation.Text = "View Conversation";
            viewConversation.UseVisualStyleBackColor = true;
            viewConversation.Click += viewConversation_Click;
            // 
            // conversations
            // 
            conversations.Location = new Point(10, 35);
            conversations.Name = "conversations";
            conversations.Size = new Size(195, 466);
            conversations.TabIndex = 9;
            // 
            // messages
            // 
            messages.AutoScroll = true;
            messages.FlowDirection = FlowDirection.TopDown;
            messages.Location = new Point(211, 35);
            messages.Name = "messages";
            messages.Size = new Size(591, 408);
            messages.TabIndex = 10;
            messages.WrapContents = false;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(211, 449);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(549, 52);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(766, 449);
            button1.Name = "button1";
            button1.Size = new Size(36, 52);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // messages_screen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(richTextBox1);
            Controls.Add(viewConversation);
            Controls.Add(messages);
            Controls.Add(conversations);
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
        private FlowLayoutPanel conversations;
        private FlowLayoutPanel messages;
        private RichTextBox richTextBox1;
        private Button button1;
    }
}
