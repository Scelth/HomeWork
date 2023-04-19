using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Мы создали абстрактный класс NPC, который определяет общий интерфейс для всех НПС.
// Классы Villager и Shopkeeper являются подтипами класса NPC и реализуют метод Talk() для разговора каждого типа персонажей.
namespace SOLID
{
    public abstract class NPC
    {
        public abstract string Talk();
    }

    class Villager : NPC
    {
        public override string Talk()
        {
            return "\tVillager says: I'll tell you about our village";
        }
    }

    class Shopkeeper : NPC
    {
        public override string Talk()
        {
            return "\tShopkeeper says: This is good stuff";
        }
    }

    public class NPCManager
    {
        public void NPCTalk(NPC npc)
        {
            Console.WriteLine(npc.Talk());
        }
    }
}