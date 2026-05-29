using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Adapter
{
    public class TelegramAdapter : IMessageService
    {
        private TelegramService adaptee;

        public TelegramAdapter(TelegramService service)
        {
            adaptee = service;
        }

        public void SendMessage(string message)
        {
            adaptee.SendTelegram(message);
        }
    }
}
