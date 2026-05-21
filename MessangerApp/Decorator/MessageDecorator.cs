using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Decorator
{
    public abstract class MessageDecorator : IChatMessage
    {
        protected IChatMessage message;

        public MessageDecorator(IChatMessage message)
        {
            this.message = message;
        }

        public virtual string GetMessage()
        {
            return message.GetMessage();
        }
    }
}
