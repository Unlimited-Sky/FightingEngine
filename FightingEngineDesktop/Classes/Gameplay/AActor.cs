using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FightingEngine.Gameplay
{
    public abstract class AActor
    {
        protected FightingEngine _game;
        public Point position { get; private set; }

        public AActor(FightingEngine game)
        {
            _game = game;
        }

        public abstract void Tick();

        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
