namespace Facade
{
    public class NPC
    {
        public bool IsAlive()
        {
            return true;
        }

        public void Talk()
        {
            Console.WriteLine("\n\tSo you got caught!");
        }

        public void Attack()
        {
            Console.WriteLine("\n\tNPC is attacking!");
        }
    }
}
