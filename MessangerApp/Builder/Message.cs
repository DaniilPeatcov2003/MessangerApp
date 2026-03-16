using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessangerApp.Builder
{
    public class ComplexMessage
    {
        public string Text { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }

        public override string ToString()
        {
            string result = Text;

            if (Image != null)
                result += " [Image: " + Image + "]";

            if (Video != null)
                result += " [Video: " + Video + "]";

            return result;
        }
    }
}
