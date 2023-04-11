using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class NPC
    {
        public string Greet()
        {
            return "Hello there!";
        }

        public string Depart()
        {
            return "Goodbye!";
        }
    }
}