using Microsoft.Xna.Framework;
using MonoGame.Forms.Controls;

namespace FightingEditor
{
    public class AnimationRenderer : InvalidationControl
    {

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void Draw()
        {
            base.Draw();

            Editor.spriteBatch.Begin();

            Editor.spriteBatch.End();
        }
    }
}