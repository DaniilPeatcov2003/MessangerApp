using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerApp.Observer
{
    public class NewsChannel : Channel
    {
        private string lastMessage;

        public void PublishMessage(string message)
        {
            lastMessage = message;

            Notify(lastMessage);
        }

        public string GetLastMessage()
        {
            return lastMessage;
        }
    }
}
