using Facade;

NPC npc = new NPC();
NPCFacade npcFacade = new NPCFacade(npc);
npcFacade.Interact();