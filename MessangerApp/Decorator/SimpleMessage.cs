using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Decorator
{
    public class SimpleMessage : IChatMessage
    {
        private readonly string text;

        public SimpleMessage(string text)
        {
            this.text = text;
        }

        public string GetMessage()
        {
            return text;
        }
    }
}
