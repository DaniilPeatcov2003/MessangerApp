using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerApp.Strategy
{
    public class MessageProcessor
    {
        private IMessageStrategy strategy;

        public MessageProcessor(IMessageStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void SetStrategy(IMessageStrategy strategy)
        {
            this.strategy = strategy;
        }

        public string Execute(string message)
        {
            return strategy.ProcessMessage(message);
        }
    }
}
