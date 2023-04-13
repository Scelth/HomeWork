namespace Facade
{
    public class NPCFacade
    {
        private NPC npc;

        public NPCFacade(NPC npc)
        {
            this.npc = npc;
        }

        public void Interact()
        {
            if (npc.IsAlive())
            {
                npc.Talk();
                npc.Attack();
            }

            else
            {
                Console.WriteLine("NPC is dead");
            }
        }
    }
}
