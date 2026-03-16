using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.AbstractFactory
{
    public class AssistantResponder : IResponder
    {
        public string Respond()
        {
            return "AssistantBot создаёт напоминание";
        }
    }
}
