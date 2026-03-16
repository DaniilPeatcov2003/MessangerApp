using MessangerApp.AbstractFactory;
using MessangerApp.Builder;
using MessangerApp.FactoryMethod;
using MessangerApp.Prototype;
using MessengerApp.Singleton;
using System;
using System.Windows.Forms;

namespace MessengerApp
{
    public partial class MainForm : Form
    {
        IBotFactory factory;
        IMessagePrototype prototype;

        public MainForm()
        {
            InitializeComponent();

            // Указываем, что в ListBox будем отображать свойство Info объектов
            lstChat.DisplayMember = "Info";

            // Добавляем ботов в ComboBox
            cmbBot.Items.Add("ChatBot");
            cmbBot.Items.Add("NewsBot");
            cmbBot.Items.Add("AssistantBot");

            cmbBot.SelectedIndex = 0;
            factory = new ChatBotFactory();
        }

        private void cmbBot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBot.SelectedIndex == 0)
                factory = new ChatBotFactory();
            else if (cmbBot.SelectedIndex == 1)
                factory = new NewsBotFactory();
            else
                factory = new AssistantBotFactory();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userText = txtMessage.Text;

            // Singleton
            var manager = WebSocketManager.Instance();
            manager.AddConnection("User");

            // Builder
            IMessageBuilder builder = new MessageBuilder();
            MessageDirector director = new MessageDirector();
            director.BuildText(builder, userText);

            var complexMessage = builder.GetResult();

            // Factory Method
            MessageCreator creator = new TextCreator();
            IMessage message = creator.CreateMessage(userText);

            // Prototype
            prototype = new TextMsg("User", message.Send());
            lstChat.Items.Add(prototype);

            // Abstract Factory
            var handler = factory.CreateHandler();
            var responder = factory.CreateResponder();

            lstChat.Items.Add(handler.Handle(userText));
            lstChat.Items.Add(responder.Respond());

            txtMessage.Clear();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (prototype == null)
            {
                MessageBox.Show("Create message first");
                return;
            }

            // Клонируем объект и добавляем его в список
            IMessagePrototype clonedMessage = prototype.Clone();
            lstChat.Items.Add(clonedMessage);
        }

        // Проверка работы Singleton
        private void btnCheckSingleton_Click(object sender, EventArgs e)
        {
            var m1 = WebSocketManager.Instance();
            var m2 = WebSocketManager.Instance();

            if (m1 == m2)
            {
                lstChat.Items.Add("Singleton работает: один экземпляр");
            }
        }

        // Получение списка подключений из Singleton
        private void btnConnections_Click(object sender, EventArgs e)
        {
            var manager = WebSocketManager.Instance();

            foreach (var user in manager.GetConnections())
            {
                lstChat.Items.Add("Connected: " + user);
            }
        }

        // IMAGE MESSAGE
        private void btnImage_Click(object sender, EventArgs e)
        {
            IMessageBuilder builder = new MessageBuilder();
            MessageDirector director = new MessageDirector();

            director.BuildImage(builder, txtMessage.Text);

            var complexMessage = builder.GetResult();

            lstChat.Items.Add("IMAGE: " + complexMessage);
        }

        // VIDEO / ATTACHMENT MESSAGE
        private void btnVideo_Click(object sender, EventArgs e)
        {
            IMessageBuilder builder = new MessageBuilder();
            MessageDirector director = new MessageDirector();

            director.BuildVideo(builder, txtMessage.Text);

            var complexMessage = builder.GetResult();

            lstChat.Items.Add("VIDEO: " + complexMessage);
        }
    }
}