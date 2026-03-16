using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.FactoryMethod
{
    public class VideoCreator : MessageCreator
    {
        public override IMessage CreateMessage(string data)
        {
            return new VideoMessage(data);
        }
    }
}
