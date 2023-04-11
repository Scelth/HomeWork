using Adapter;

NPC npc = new();
INPC inpc = new NPCAdapter(npc);

Console.WriteLine(inpc.SayHello());
Console.WriteLine(inpc.SayGoodbye());