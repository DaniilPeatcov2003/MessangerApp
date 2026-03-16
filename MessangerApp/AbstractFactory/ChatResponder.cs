using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.AbstractFactory
{
    public class ChatResponder : IResponder
    {
        public string Respond()
        {
            return "ChatBot отвечает пользователю";
        }
    }
}
