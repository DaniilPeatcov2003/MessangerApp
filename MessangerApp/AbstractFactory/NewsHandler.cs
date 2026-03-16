using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.AbstractFactory
{
    public class NewsHandler : IMessageHandler
    {
        public string Handle(string message)
        {
            return "NewsBot получает новости";
        }
    }
}
