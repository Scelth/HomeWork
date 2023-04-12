using Proxy;

Client client = new();
Console.WriteLine("\n\tClient: Executing the client code with a real subject:");
NPC npc = new("Dagoth Ur");
client.Call(npc);

Console.WriteLine("\n\tClient: Executing the same client code with a proxy:");
NPCProxy proxy = new(npc);
client.Call(proxy);