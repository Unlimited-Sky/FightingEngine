using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FightingEngine
{
    public abstract class AActor
    {
        public Point position { get; private set; }

        public AActor() { }

        public abstract void Tick();

        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
