using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DZ2
{
    public class Player
    {
        public short Num { get; set; }
        public static short count = 1;

        public override string ToString()
        {
            return $"{count++}. Your choice: {Num}";
        }
    }
}
