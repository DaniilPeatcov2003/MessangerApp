using MessangerApp.AbstractFactory;
using MessangerApp.Adapter;
using MessangerApp.Adapter.MessengerApp.Adapter;
using MessangerApp.Builder;
using MessangerApp.Decorator;
using MessangerApp.FactoryMethod;
using MessangerApp.Prototype;
using MessengerApp.Observer;
using MessengerApp.Singleton;
using MessengerApp.Strategy;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MessengerApp
{
    public partial class MainForm : Form
    {
        IBotFactory factory;
        IMessagePrototype? prototype;

        private NewsChannel newsChannel = new NewsChannel();

        public MainForm()
        {
            InitializeComponent();

            cmbBot.Items.Add("ChatBot");
            cmbBot.Items.Add("NewsBot");
            cmbBot.Items.Add("AssistantBot");
            cmbBot.SelectedIndex = 0;

            factory = new ChatBotFactory();

            newsChannel.Subscribe(new UserObserver("User1"));
            newsChannel.Subscribe(new UserObserver("User2"));
        }

        private void cmbBot_SelectedIndexChanged(object sender, EventArgs e)
        {
            string botName;
            string greeting;

            switch (cmbBot.SelectedIndex)
            {
                case 0:
                    factory = new ChatBotFactory();
                    botName = "ChatBot";
                    greeting = "Привет! Я ChatBot. Чем могу помочь?";
                    break;

                case 1:
                    factory = new NewsBotFactory();
                    botName = "NewsBot";
                    greeting = "Привет! Я NewsBot. Готов показать новости!";
                    break;

                default:
                    factory = new AssistantBotFactory();
                    botName = "AssistantBot";
                    greeting = "Привет! Я AssistantBot. Готов помочь!";
                    break;
            }

            AddMessage(botName, greeting, false, BubbleKind.Bot);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userText = txtMessage.Text;

            if (string.IsNullOrWhiteSpace(userText))
                return;

            IChatMessage message = new SimpleMessage(userText);

            string? emoji = cmbEmoji.SelectedItem as string;

            if (!string.IsNullOrWhiteSpace(emoji)
                && emoji != "Emoji")
            {
                message = new EmojiDecorator(message, emoji);
            }

            string? sticker = cmbSticker.SelectedItem as string;

            if (!string.IsNullOrWhiteSpace(sticker)
                && sticker != "Sticker")
            {
                message = new StickerDecorator(message, sticker);
            }

            string finalMessage = message.GetMessage();

            AddMessage("Вы", finalMessage, true, BubbleKind.User);

            var manager = WebSocketManager.Instance();
            manager.AddConnection("User");

            IMessageBuilder builder = new MessageBuilder();
            var director = new MessageDirector();
            director.BuildText(builder, userText);
            builder.GetResult();

            MessageCreator creator = new TextCreator();
            IMessage msg = creator.CreateMessage(userText);

            prototype = new TextMsg("User", msg.Send());

            string botName = cmbBot.SelectedItem?.ToString() ?? "Bot";

            var handler = factory.CreateHandler();
            var responder = factory.CreateResponder();

            AddMessage(botName, handler.Handle(userText), false, BubbleKind.Bot);
            AddMessage(botName, responder.Respond(), false, BubbleKind.Bot);

            IMessageService telegram = new TelegramAdapter(new TelegramService());
            IMessageService whatsapp = new WhatsAppAdapter(new WhatsAppService());

            telegram.SendMessage(finalMessage);
            whatsapp.SendMessage(finalMessage);

            AddMessage("System", "Отправлено в Telegram и WhatsApp", false, BubbleKind.System);

            newsChannel.PublishMessage("Новое сообщение: " + finalMessage);

            var processor = new MessageProcessor(new SimpleStrategy());
            AddMessage("Simple", processor.Execute(finalMessage), false, BubbleKind.System);

            processor.SetStrategy(new AIStrategy());
            AddMessage("AI", processor.Execute(finalMessage), false, BubbleKind.System);

            txtMessage.Clear();

            cmbEmoji.SelectedIndex = -1;
            cmbSticker.SelectedIndex = -1;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (prototype == null)
            {
                MessageBox.Show("Сначала отправьте сообщение.");

                return;
            }

            IMessagePrototype cloned = prototype.Clone();
            AddMessage("Forwarded", cloned.GetInfo(), false, BubbleKind.System);
        }

        private void btnCheckSingleton_Click(object sender, EventArgs e)
        {
            var m1 = WebSocketManager.Instance();
            var m2 = WebSocketManager.Instance();

            AddMessage("Singleton", m1 == m2 ? "Один экземпляр" : "Ошибка Singleton", false, BubbleKind.System);
        }

        private void btnConnections_Click(object sender, EventArgs e)
        {
            var manager = WebSocketManager.Instance();

            foreach (var user in manager.GetConnections())
            {
                AddMessage("Connections", user, false, BubbleKind.System);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var b = new MessageBuilder();
            new MessageDirector().BuildImage(b, txtMessage.Text);
            AddMessage("Вы", "Изображение отправлено", true, BubbleKind.User);
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            var b = new MessageBuilder();

            new MessageDirector().BuildVideo(b, txtMessage.Text);

            AddMessage("Вы", "Видео отправлено", true, BubbleKind.User);
        }

        private enum BubbleKind { User, Bot, System }

        private void AddMessage(string sender, string text, bool isUser, BubbleKind kind)
        {
            Color bgColor =
                kind == BubbleKind.User
                ? Color.LightBlue
                : kind == BubbleKind.Bot
                ? Color.White
                : Color.LightGray;

            int chatW =
                pnlChat.ClientSize.Width - 20;

            int maxBubW =
                (int)(chatW * 0.65);

            Size measured =
                TextRenderer.MeasureText(
                    text,
                    new Font("Segoe UI", 10F),
                    new Size(maxBubW, int.MaxValue),
                    TextFormatFlags.WordBreak);

            var row = new Panel
            {
                Width = chatW,
                Height = measured.Height + 60,
                BackColor = Color.Transparent
            };

            var lblSender = new Label
            {
                Text = sender,
                Font = new Font(
                    "Segoe UI",
                    8F,
                    FontStyle.Bold),

                AutoSize = true,
                ForeColor = Color.DimGray
            };

            var bubble = new Panel
            {
                Size = new Size(
                    measured.Width + 20,
                    measured.Height + 20),

                BackColor = bgColor,
                BorderStyle =
                    BorderStyle.FixedSingle
            };

            var label = new Label
            {
                Text = text,
                AutoSize = false,
                Size = new Size(
                    bubble.Width - 10,
                    bubble.Height - 10),

                Location = new Point(5, 5)
            };

            bubble.Controls.Add(label);

            int left =
                isUser
                ? chatW - bubble.Width - 10
                : 5;

            lblSender.Location =
                new Point(left, 0);

            bubble.Left = left;
            bubble.Top = 18;
            row.Controls.Add(lblSender);
            row.Controls.Add(bubble);

            pnlChat.Controls.Add(row);

            pnlChat.ScrollControlIntoView(row);
        }

        private void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}