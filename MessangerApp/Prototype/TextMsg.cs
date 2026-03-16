using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Prototype
{
    public class TextMsg : IMessagePrototype
    {
        public string Sender { get; set; }
        public string Text { get; set; }

        public string Info => $"User: {Text}";

        public TextMsg(string sender, string text)
        {
            Sender = sender;
            Text = text;
        }

        public IMessagePrototype Clone()
        {
            return new TextMsg(Sender, Text);
        }

        public string GetInfo()
        {
            return Info;
        }
    }
}
