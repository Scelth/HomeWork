using Bridge;

Peaceful peaceful = new(new WeakAssigner());
peaceful.Group();

Hostile hostile = new(new StrongAssigner());
hostile.Group();