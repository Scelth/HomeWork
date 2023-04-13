using TemplateMethod;

WantsToTalk.Wants_To_Talk = true;

NPC npc = new Shopkeeper();
npc.Interact();

npc = new Villager();
npc.Interact();