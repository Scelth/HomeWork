using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Мы расширяем, но не изменяем код каждый раз, как добавляется новый тип
namespace SOLID
{
    public abstract class NPC
    {
        public abstract void Talk();
    }

    class Villager : NPC
    {
        public override void Talk()
        {
            Console.WriteLine("\tVillager says: I'll tell you about our village");
        }
    }

    class Shopkeeper : NPC
    {
        public override void Talk()
        {
            Console.WriteLine("\tShopkeeper says: This is good stuff");
        }
    }
}
