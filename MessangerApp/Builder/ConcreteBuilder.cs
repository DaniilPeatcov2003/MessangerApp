using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Builder
{
    public class MessageBuilder : IMessageBuilder
    {
        private ComplexMessage message = new ComplexMessage();

        public void AddText(string text)
        {
            message.Text = text;
        }

        public void AddImage(string image)
        {
            message.Image = image;
        }

        public void AddVideo(string video)
        {
            message.Video = video;
        }

        public ComplexMessage GetResult()
        {
            return message;
        }
    }
}
