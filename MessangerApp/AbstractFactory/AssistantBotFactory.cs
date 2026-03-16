using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.AbstractFactory
{
    public class AssistantBotFactory : IBotFactory
    {
        public IMessageHandler CreateHandler()
        {
            return new AssistantHandler();
        }

        public IResponder CreateResponder()
        {
            return new AssistantResponder();
        }
    }
}
