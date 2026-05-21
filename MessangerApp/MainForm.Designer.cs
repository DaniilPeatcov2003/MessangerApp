namespace MessengerApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbBot = new ComboBox();
            txtMessage = new TextBox();
            pnlChat = new FlowLayoutPanel();
            btnSend = new Button();
            btnImage = new Button();
            btnVideo = new Button();
            btnForward = new Button();
            btnCheckSingleton = new Button();
            btnConnections = new Button();
            cmbEmoji = new ComboBox();
            cmbSticker = new ComboBox();
            pnlTop = new Panel();
            lblOnline = new Label();
            pnlBottom = new Panel();
            pnlRight = new Panel();
            pnlDivV = new Panel();
            pnlDivH = new Panel();
            pnlDivTop = new Panel();
            pnlTop.SuspendLayout();
            pnlBottom.SuspendLayout();
            pnlRight.SuspendLayout();
            SuspendLayout();
 
            cmbBot.BackColor = Color.White;
            cmbBot.FlatStyle = FlatStyle.Flat;
            cmbBot.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            cmbBot.ForeColor = Color.FromArgb(30, 30, 30);
            cmbBot.FormattingEnabled = true;
            cmbBot.Location = new Point(12, 12);
            cmbBot.Name = "cmbBot";
            cmbBot.Size = new Size(260, 33);
            cmbBot.TabIndex = 0;
            cmbBot.SelectedIndexChanged += cmbBot_SelectedIndexChanged;
 
            txtMessage.BackColor = Color.FromArgb(245, 245, 240);
            txtMessage.BorderStyle = BorderStyle.FixedSingle;
            txtMessage.Font = new Font("Segoe UI", 11F);
            txtMessage.ForeColor = Color.FromArgb(30, 30, 30);
            txtMessage.Location = new Point(12, 17);
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "Введите сообщение...";
            txtMessage.Size = new Size(510, 32);
            txtMessage.TabIndex = 1;
            txtMessage.TextChanged += txtMessage_TextChanged;

            pnlChat.AutoScroll = true;
            pnlChat.BackColor = Color.FromArgb(250, 249, 245);
            pnlChat.FlowDirection = FlowDirection.TopDown;
            pnlChat.Location = new Point(0, 57);
            pnlChat.Name = "pnlChat";
            pnlChat.Padding = new Padding(10, 8, 10, 8);
            pnlChat.Size = new Size(800, 572);
            pnlChat.TabIndex = 4;
            pnlChat.WrapContents = false;

            btnSend.BackColor = Color.FromArgb(59, 91, 219);
            btnSend.Cursor = Cursors.Hand;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(534, 15);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(90, 38);
            btnSend.TabIndex = 3;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;

            btnImage.BackColor = Color.White;
            btnImage.Cursor = Cursors.Hand;
            btnImage.FlatAppearance.BorderColor = Color.FromArgb(218, 216, 208);
            btnImage.FlatStyle = FlatStyle.Flat;
            btnImage.Font = new Font("Segoe UI", 10F);
            btnImage.ForeColor = Color.FromArgb(40, 40, 40);
            btnImage.Location = new Point(24, 120);
            btnImage.Name = "btnImage";
            btnImage.Padding = new Padding(14, 0, 0, 0);
            btnImage.Size = new Size(252, 46);
            btnImage.TabIndex = 4;
            btnImage.Text = "Send Image";
            btnImage.TextAlign = ContentAlignment.MiddleLeft;
            btnImage.UseVisualStyleBackColor = false;
            btnImage.Click += btnImage_Click;

            btnVideo.BackColor = Color.White;
            btnVideo.Cursor = Cursors.Hand;
            btnVideo.FlatAppearance.BorderColor = Color.FromArgb(218, 216, 208);
            btnVideo.FlatStyle = FlatStyle.Flat;
            btnVideo.Font = new Font("Segoe UI", 10F);
            btnVideo.ForeColor = Color.FromArgb(40, 40, 40);
            btnVideo.Location = new Point(24, 180);
            btnVideo.Name = "btnVideo";
            btnVideo.Padding = new Padding(14, 0, 0, 0);
            btnVideo.Size = new Size(252, 46);
            btnVideo.TabIndex = 5;
            btnVideo.Text = "Send Video";
            btnVideo.TextAlign = ContentAlignment.MiddleLeft;
            btnVideo.UseVisualStyleBackColor = false;
            btnVideo.Click += btnVideo_Click;

            btnForward.BackColor = Color.White;
            btnForward.Cursor = Cursors.Hand;
            btnForward.FlatAppearance.BorderColor = Color.FromArgb(218, 216, 208);
            btnForward.FlatStyle = FlatStyle.Flat;
            btnForward.Font = new Font("Segoe UI", 10F);
            btnForward.ForeColor = Color.FromArgb(40, 40, 40);
            btnForward.Location = new Point(24, 60);
            btnForward.Name = "btnForward";
            btnForward.Padding = new Padding(14, 0, 0, 0);
            btnForward.Size = new Size(252, 46);
            btnForward.TabIndex = 6;
            btnForward.Text = "Forward";
            btnForward.TextAlign = ContentAlignment.MiddleLeft;
            btnForward.UseVisualStyleBackColor = false;
            btnForward.Click += btnForward_Click;

            btnCheckSingleton.BackColor = Color.White;
            btnCheckSingleton.Cursor = Cursors.Hand;
            btnCheckSingleton.FlatAppearance.BorderColor = Color.FromArgb(218, 216, 208);
            btnCheckSingleton.FlatStyle = FlatStyle.Flat;
            btnCheckSingleton.Font = new Font("Segoe UI", 10F);
            btnCheckSingleton.ForeColor = Color.FromArgb(40, 40, 40);
            btnCheckSingleton.Location = new Point(24, 300);
            btnCheckSingleton.Name = "btnCheckSingleton";
            btnCheckSingleton.Padding = new Padding(14, 0, 0, 0);
            btnCheckSingleton.Size = new Size(252, 46);
            btnCheckSingleton.TabIndex = 8;
            btnCheckSingleton.Text = "Check Singleton";
            btnCheckSingleton.TextAlign = ContentAlignment.MiddleLeft;
            btnCheckSingleton.UseVisualStyleBackColor = false;
            btnCheckSingleton.Click += btnCheckSingleton_Click;

            btnConnections.BackColor = Color.White;
            btnConnections.Cursor = Cursors.Hand;
            btnConnections.FlatAppearance.BorderColor = Color.FromArgb(218, 216, 208);
            btnConnections.FlatStyle = FlatStyle.Flat;
            btnConnections.Font = new Font("Segoe UI", 10F);
            btnConnections.ForeColor = Color.FromArgb(40, 40, 40);
            btnConnections.Location = new Point(24, 240);
            btnConnections.Name = "btnConnections";
            btnConnections.Padding = new Padding(14, 0, 0, 0);
            btnConnections.Size = new Size(252, 46);
            btnConnections.TabIndex = 7;
            btnConnections.Text = "Connections";
            btnConnections.TextAlign = ContentAlignment.MiddleLeft;
            btnConnections.UseVisualStyleBackColor = false;
            btnConnections.Click += btnConnections_Click;

            cmbEmoji.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmoji.Font = new Font("Segoe UI", 9F);
            cmbEmoji.Items.AddRange(new object[] { "Emoji", "😂", "❤️", "😍", "😄", "😐" });
            cmbEmoji.Location = new Point(632, 18);
            cmbEmoji.Name = "cmbEmoji";
            cmbEmoji.Size = new Size(72, 28);
            cmbEmoji.TabIndex = 9;

            cmbSticker.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSticker.Font = new Font("Segoe UI", 9F);
            cmbSticker.Items.AddRange(new object[] { "Sticker", "Cat", "Dog", "Meme" });
            cmbSticker.Location = new Point(710, 18);
            cmbSticker.Name = "cmbSticker";
            cmbSticker.Size = new Size(76, 28);
            cmbSticker.TabIndex = 10;

            pnlTop.BackColor = Color.White;
            pnlTop.Controls.Add(cmbBot);
            pnlTop.Controls.Add(lblOnline);
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(800, 56);
            pnlTop.TabIndex = 3;

            lblOnline.AutoSize = true;
            lblOnline.BackColor = Color.Transparent;
            lblOnline.Font = new Font("Segoe UI", 9F);
            lblOnline.ForeColor = Color.FromArgb(56, 176, 100);
            lblOnline.Location = new Point(280, 20);
            lblOnline.Name = "lblOnline";
            lblOnline.Size = new Size(61, 20);
            lblOnline.TabIndex = 1;
            lblOnline.Text = "онлайн";

            pnlBottom.BackColor = Color.White;
            pnlBottom.Controls.Add(txtMessage);
            pnlBottom.Controls.Add(btnSend);
            pnlBottom.Controls.Add(cmbEmoji);
            pnlBottom.Controls.Add(cmbSticker);
            pnlBottom.Location = new Point(0, 630);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(800, 70);
            pnlBottom.TabIndex = 5;

            pnlRight.BackColor = Color.FromArgb(244, 243, 238);
            pnlRight.Controls.Add(btnForward);
            pnlRight.Controls.Add(btnImage);
            pnlRight.Controls.Add(btnVideo);
            pnlRight.Controls.Add(btnConnections);
            pnlRight.Controls.Add(btnCheckSingleton);
            pnlRight.Location = new Point(800, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(300, 700);
            pnlRight.TabIndex = 6;

            pnlDivV.BackColor = Color.FromArgb(218, 216, 208);
            pnlDivV.Location = new Point(799, 0);
            pnlDivV.Name = "pnlDivV";
            pnlDivV.Size = new Size(1, 700);
            pnlDivV.TabIndex = 2;

            pnlDivH.BackColor = Color.FromArgb(218, 216, 208);
            pnlDivH.Location = new Point(0, 629);
            pnlDivH.Name = "pnlDivH";
            pnlDivH.Size = new Size(800, 1);
            pnlDivH.TabIndex = 1;

            pnlDivTop.BackColor = Color.FromArgb(218, 216, 208);
            pnlDivTop.Location = new Point(0, 56);
            pnlDivTop.Name = "pnlDivTop";
            pnlDivTop.Size = new Size(800, 1);
            pnlDivTop.TabIndex = 0;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 249, 245);
            ClientSize = new Size(1100, 700);
            Controls.Add(pnlDivTop);
            Controls.Add(pnlDivH);
            Controls.Add(pnlDivV);
            Controls.Add(pnlTop);
            Controls.Add(pnlChat);
            Controls.Add(pnlBottom);
            Controls.Add(pnlRight);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Messenger App";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            pnlRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        private ComboBox cmbBot;
        private TextBox txtMessage;
        private FlowLayoutPanel pnlChat;
        private Button btnSend;
        private Button btnImage;
        private Button btnVideo;
        private Button btnForward;
        private Button btnCheckSingleton;
        private Button btnConnections;
        private ComboBox cmbEmoji;
        private ComboBox cmbSticker;
        private Panel pnlTop;
        private Panel pnlBottom;
        private Panel pnlRight;
        private Panel pnlDivV;
        private Panel pnlDivH;
        private Panel pnlDivTop;
        private Label lblOnline;
    }
}