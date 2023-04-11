using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class NPCAdapter : INPC
    {
        private readonly NPC _npc;

        public NPCAdapter(NPC npc)
        {
            _npc = npc;
        }

        public string SayHello()
        {
            return $"\n\tNPC says: {_npc.Greet()}";
        }

        public string SayGoodbye()
        {
            return $"\n\tNPC says: {_npc.Depart()}";
        }
    }
}