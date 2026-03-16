using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Builder
{
    public interface IMessageBuilder
    {
        void AddText(string text);
        void AddImage(string image);
        void AddVideo(string video);
        ComplexMessage GetResult();
    }
}
