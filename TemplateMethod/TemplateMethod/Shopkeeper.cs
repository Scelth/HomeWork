namespace TemplateMethod
{
    class Shopkeeper : NPC
    {
        protected override void Greet()
        {
            Console.WriteLine("\n\tShopkeeper says: Welcome to my store!");
        }

        protected override void Fear()
        {
            Console.WriteLine("\n\tShopkeeper says: Go away! I will not bargain with criminals!");
        }

        protected override void Farewell()
        {
            Console.WriteLine("\tShopkeeper says: Thank you for your purchase!");
        }

        protected override void Talk()
        {
            Console.WriteLine("\tShopkeeper says: This is good stuff");
        }
    }
}