using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Client
    {
        public void Call(INPC iNPC)
        {
            iNPC.Talk();
        }
    }
}
