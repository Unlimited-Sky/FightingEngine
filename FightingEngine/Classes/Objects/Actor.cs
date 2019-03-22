using Microsoft.Xna.Framework;

namespace FightingEngine.Classes
{
    //An object tied to gameplay logic
    public abstract class Actor
    {
        public Actor() { }

        public abstract void Tick();
    }
}
