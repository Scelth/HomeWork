using Git.Model;
using Git.Realization;

NPCModel model = new();
model.Name = "Miraak";

NPCRealization NPC = new(model.Name);
NPC.Greet();