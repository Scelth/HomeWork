using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class StrongAssigner : IAssigner
    {
        public void Assign(string who)
        {
            Console.WriteLine($"\n\tThis {who} character is strong");
        }
    }
}
