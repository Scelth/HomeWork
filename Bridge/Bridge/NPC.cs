using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class NPC
    {
        protected IAssigner assigner;

        public NPC(IAssigner _assigner)
        {
            assigner = _assigner;
        }

        public abstract void Group();
    }
}
