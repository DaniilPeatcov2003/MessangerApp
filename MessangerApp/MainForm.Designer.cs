namespace MessengerApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbBot = new ComboBox();
            txtMessage = new TextBox();
            lstChat = new ListBox();
            btnSend = new Button();
            btnImage = new Button();
            btnVideo = new Button();
            btnForward = new Button();
            btnCheckSingleton = new Button();
            btnConnections = new Button();
            SuspendLayout();
            // 
            // cmbBot
            // 
            cmbBot.FormattingEnabled = true;
            cmbBot.Location = new Point(252, 37);
            cmbBot.Name = "cmbBot";
            cmbBot.Size = new Size(151, 28);
            cmbBot.TabIndex = 0;
            cmbBot.SelectedIndexChanged += cmbBot_SelectedIndexChanged;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(278, 71);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(125, 27);
            txtMessage.TabIndex = 1;
            // 
            // lstChat
            // 
            lstChat.FormattingEnabled = true;
            lstChat.Location = new Point(50, 158);
            lstChat.Name = "lstChat";
            lstChat.Size = new Size(353, 104);
            lstChat.TabIndex = 3;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(426, 233);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 4;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnImage
            // 
            btnImage.Location = new Point(309, 290);
            btnImage.Name = "btnImage";
            btnImage.Size = new Size(94, 29);
            btnImage.TabIndex = 5;
            btnImage.Text = "Image";
            btnImage.UseVisualStyleBackColor = true;
            btnImage.Click += btnImage_Click;
            // 
            // btnVideo
            // 
            btnVideo.Location = new Point(426, 290);
            btnVideo.Name = "btnVideo";
            btnVideo.Size = new Size(94, 29);
            btnVideo.TabIndex = 6;
            btnVideo.Text = "Video";
            btnVideo.UseVisualStyleBackColor = true;
            btnVideo.Click += btnVideo_Click;
            // 
            // btnForward
            // 
            btnForward.Location = new Point(426, 172);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(94, 29);
            btnForward.TabIndex = 7;
            btnForward.Text = "Forward";
            btnForward.UseVisualStyleBackColor = true;
            btnForward.Click += btnForward_Click;
            // 
            // btnCheckSingleton
            // 
            btnCheckSingleton.Location = new Point(172, 290);
            btnCheckSingleton.Name = "btnCheckSingleton";
            btnCheckSingleton.Size = new Size(131, 29);
            btnCheckSingleton.TabIndex = 8;
            btnCheckSingleton.Text = "Check Singleton";
            btnCheckSingleton.UseVisualStyleBackColor = true;
            btnCheckSingleton.Click += btnCheckSingleton_Click;
            // 
            // btnConnections
            // 
            btnConnections.Location = new Point(68, 290);
            btnConnections.Name = "btnConnections";
            btnConnections.Size = new Size(103, 29);
            btnConnections.TabIndex = 9;
            btnConnections.Text = "Connections";
            btnConnections.UseVisualStyleBackColor = true;
            btnConnections.Click += btnConnections_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnConnections);
            Controls.Add(btnCheckSingleton);
            Controls.Add(btnForward);
            Controls.Add(btnVideo);
            Controls.Add(btnImage);
            Controls.Add(btnSend);
            Controls.Add(lstChat);
            Controls.Add(txtMessage);
            Controls.Add(cmbBot);
            Name = "MainForm";
            Text = "Messenger App";
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox cmbBot;
        private TextBox txtMessage;
        private ListBox lstChat;
        private Button btnSend;
        private Button btnImage;
        private Button btnVideo;
        private Button btnForward;
        private Button btnCheckSingleton;
        private Button btnConnections;
    }
}