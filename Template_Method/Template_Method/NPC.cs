namespace Template_Method
{
    abstract class NPC
    {
        public void Interact()
        {
            if (WantsToTalk.Wants_To_Talk)
            {
                Greet();
                Talk();
                Farewell();
            }

            else
            {
                Fear();
            }

        }

        protected abstract void Greet();
        protected abstract void Fear();
        protected abstract void Farewell();
        protected abstract void Talk();
    }
}