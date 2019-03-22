using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FightingEngine.Classes
{
    //An object which can render itself
    abstract class RenderableObject
    {
        protected Point _position;

        public abstract void Draw(SpriteBatch spriteBatch);
    }
}
