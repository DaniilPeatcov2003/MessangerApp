using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Decorator
{
    public class StickerDecorator : MessageDecorator
    {
        private string sticker;

        public StickerDecorator(IChatMessage message, string sticker) : base(message)
        {
            this.sticker = sticker ?? "";
        }

        public override string GetMessage()
        {
            return base.GetMessage() + " [Sticker: " + sticker + "]";
        }
    }
}
