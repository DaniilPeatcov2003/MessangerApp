using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.FactoryMethod
{
    public class TextMessage : IMessage
    {
        private string text;

        public TextMessage(string text)
        {
            this.text = text;
        }

        public string Send()
        {
            return text;
        }
    }
}
