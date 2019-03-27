using FightingEngine.Animation;
using Microsoft.Xna.Framework;
using MonoGame.Forms.Controls;

namespace FightingEditor
{
    public class AnimationRenderer : InvalidationControl
    {

        public Animator animator;

        protected override void Initialize()
        {
            base.Initialize();
            animator = new Animator();
        }

        protected override void Draw()
        {
            base.Draw();

            Editor.spriteBatch.Begin();

            Editor.spriteBatch.End();
        }
    }
}