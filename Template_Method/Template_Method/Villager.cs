namespace Template_Method
{
    class Villager : NPC
    {
        protected override void Greet()
        {
            Console.WriteLine("\n\tVillager says: Hi, how are you?");
        }

        protected override void Fear()
        {
            Console.WriteLine("\n\tVillager says: Go away! Please don't kill me!");
        }

        protected override void Farewell()
        {
            Console.WriteLine("\tVillager says: Bye, see you later!");
        }

        protected override void Talk()
        {
            Console.WriteLine("\tVillager says: I'll tell you about our village");
        }
    }
}
