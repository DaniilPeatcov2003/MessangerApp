using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Adapter
{
    public class WhatsAppService
    {
        public void SendWhatsAppMessage(string msg)
        {
            Console.WriteLine("WhatsApp: " + msg);
        }
    }
}
