using Builder;

NPCBuilder builder = new();
builder.SetName("The Guard");
builder.SetHealth(50);
builder.SetStamina(64);
builder.SetDifficulty(7);

builder.Build();