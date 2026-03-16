using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.FactoryMethod
{
    public class VideoMessage : IMessage
    {
        private string path;

        public VideoMessage(string path)
        {
            this.path = path;
        }

        public string Send()
        {
            return "VIDEO: " + path;
        }
    }
}
