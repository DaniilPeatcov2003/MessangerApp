using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.FactoryMethod
{
    public abstract class MessageCreator
    {
        public abstract IMessage CreateMessage(string data);
    }
}
