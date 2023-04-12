using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Proxy
{
    internal class NPCProxy : INPC
    {
        private NPC _realNPC;

        public NPCProxy(NPC realNPC)
        {
            _realNPC = realNPC;
        }

        public void Talk()
        {
            Console.WriteLine("\tProxy: Sending a request to a real NPC");
            _realNPC.Talk();
        }
    }
}
