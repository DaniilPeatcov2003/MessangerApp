using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Adapter
{
    public class TelegramService
    {
        public void SendTelegram(string text)
        {
            Console.WriteLine("Telegram: " + text);
        }
    }
}
