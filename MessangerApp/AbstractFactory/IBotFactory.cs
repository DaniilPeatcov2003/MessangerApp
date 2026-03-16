using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.AbstractFactory
{
    public interface IBotFactory
    {
        IMessageHandler CreateHandler();
        IResponder CreateResponder();
    }
}
