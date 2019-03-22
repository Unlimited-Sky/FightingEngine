using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FightingEngine.Classes.Objects
{
    //An object which draws itself, but doesnt ever move or animate
    class StaticRenderableObject : RenderableObject
    {
        private Texture2D _texture;

        public StaticRenderableObject(Texture2D texture, Point position)
        {
            _texture = texture;
            _position = position;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_texture, _position.ToVector2(), Color.White);
        }
    }
}
