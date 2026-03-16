using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.AbstractFactory
{
    public class NewsBotFactory : IBotFactory
    {
        public IMessageHandler CreateHandler()
        {
            return new NewsHandler();
        }

        public IResponder CreateResponder()
        {
            return new NewsResponder();
        }
    }
}
