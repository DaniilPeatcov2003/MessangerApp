using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Prototype
{
    public interface IMessagePrototype
    {
        IMessagePrototype Clone();
        string GetInfo();
    }
}
