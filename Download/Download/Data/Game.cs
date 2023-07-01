using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Download.Data
{
    public class Game
    {
        public string Name { get; set; }
        public string Studio { get; set; }
        public string Description { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public List<string> Genre { get; set; } = new();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
