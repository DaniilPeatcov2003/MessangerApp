using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerApp.Strategy
{
    public class SimpleStrategy : IMessageStrategy
    {
        public string ProcessMessage(string message)
        {
            return "Обычное сообщение: " + message;
        }
    }
}
