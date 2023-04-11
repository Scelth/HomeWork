using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Hostile : NPC
    {
        public Hostile(IAssigner assigner) : base(assigner) { }
        public override void Group()
        {
            assigner.Assign("Hostile");
        }
    }
}
