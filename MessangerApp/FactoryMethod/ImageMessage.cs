using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.FactoryMethod
{
    public class ImageMessage : IMessage
    {
        private string path;

        public ImageMessage(string path)
        {
            this.path = path;
        }

        public string Send()
        {
            return "IMAGE: " + path;
        }
    }
}
