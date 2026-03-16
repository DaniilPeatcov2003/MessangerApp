using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Builder
{
    public class MessageDirector
    {
        public void BuildText(IMessageBuilder builder, string text)
        {
            builder.AddText(text);
        }

        public void BuildImage(IMessageBuilder builder, string text)
        {
            builder.AddText(text);
            builder.AddImage("photo.png");
        }

        public void BuildVideo(IMessageBuilder builder, string text)
        {
            builder.AddText(text);
            builder.AddVideo("video.mp4");
        }
    }
}
