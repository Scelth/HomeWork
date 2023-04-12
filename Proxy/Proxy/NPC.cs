using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class NPC : INPC
    {
        private string Name;

        public NPC(string name)
        {
            Name = name;
        }

        public void Talk()
        {
            Console.WriteLine($"\tGreetings hero! My name is {Name}. I will help you in your wanderings");
        }
    }
}
