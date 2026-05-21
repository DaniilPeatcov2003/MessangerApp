using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Decorator
{
    public class EmojiDecorator : MessageDecorator
    {
        private string emoji;

        public EmojiDecorator(IChatMessage message, string emoji) : base(message)
        {
            this.emoji = emoji ?? "";
        }

        public override string GetMessage()
        {
            return base.GetMessage() + " " + emoji;
        }
    }
}
