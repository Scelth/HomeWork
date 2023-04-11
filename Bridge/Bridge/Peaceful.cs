using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Peaceful : NPC
    {
        public Peaceful(IAssigner assigner) : base(assigner) { }
        public override void Group()
        {
            assigner.Assign("Peaceful");
        }
    }
}