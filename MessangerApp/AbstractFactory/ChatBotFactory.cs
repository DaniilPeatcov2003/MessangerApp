using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.AbstractFactory
{
    public class ChatBotFactory : IBotFactory
    {
        public IMessageHandler CreateHandler()
        {
            return new ChatHandler();
        }

        public IResponder CreateResponder()
        {
            return new ChatResponder();
        }
    }
}
