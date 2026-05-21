using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerApp.Strategy
{
    public class AIStrategy : IMessageStrategy
    {
        public string ProcessMessage(string message)
        {
            return "AI анализирует сообщение: " + message;
        }
    }
}
