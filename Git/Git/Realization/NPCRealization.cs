using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Git.Realization
{
    internal class NPCRealization
    {
        public string Name { get; set; }

        public NPCRealization(string _name)
        {
            Name = _name;
        }

        public void Greet()
        {
            Console.WriteLine($"\n\t{Name} says: Welcome, hero!!");
        }

        public void Talk()
        {
            Console.WriteLine($"\t{Name} says: I'll tell you about our village");
        }

        public void Farewell()
        {
            Console.WriteLine($"\t{Name} says: Bye, see you later!");
        }
    }
}
