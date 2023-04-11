using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy
{
    public class Doc : ICloneable
    {
        public string Name { get; set; } = "New Doc";
        public string Text { get; set; } = "";
        public int FontSize { get; set; } = 20;

        public Doc() { }
        public Doc(string name, string text, int fontsize)
        {
            Name = name;
            Text = text;
            FontSize = fontsize;
        }

        public object Clone() => new Doc()
        {
            Name = this.Name,
            Text = this.Text,
            FontSize = this.FontSize
        };
    }
}