using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Adapter
{
    namespace MessengerApp.Adapter
    {
        public class WhatsAppAdapter : IMessageService
        {
            private WhatsAppService adaptee;

            public WhatsAppAdapter(WhatsAppService service)
            {
                adaptee = service;
            }

            public void SendMessage(string message)
            {
                adaptee.SendWhatsAppMessage(message);
            }
        }
    }
}
