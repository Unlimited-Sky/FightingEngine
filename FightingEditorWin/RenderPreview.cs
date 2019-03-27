using FightingEngine.Animation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Forms.Controls;
using System;
using System.Collections.Generic;
using System.IO;

namespace FightingEditor
{
    public class RenderPreview : MonoGameControl
    {
        public Animator animator;
        public List<Texture2D> textures;
        public List<int> keyFrameLenghts;
        public FightingEditorForm editorForm;

        public float renderScale = 3.0f;
       
        protected override void Initialize()
        {
            base.Initialize();

            animator = new Animator();

            textures = new List<Texture2D>();
            keyFrameLenghts = new List<int>();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if (animator != null && animator.AnimData != null)
            {
                animator.Tick();

                if (animator.IsPlaying)
                    editorForm.UpdateFormFields();
            }
        }

        protected override void Draw()
        {
            base.Draw();

            Editor.spriteBatch.Begin();

            if (animator != null && animator.AnimData != null)
            {
                animator.Draw(Editor.spriteBatch,
                    new Vector2(Editor.graphics.Viewport.Width / 2, Editor.graphics.Viewport.Height / 2));
                Editor.spriteBatch.DrawString(Editor.Font, animator.CurrentFrame.ToString(), new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString(animator.CurrentFrame.ToString()).X / 2),
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2)),
                Color.White);
            }

            Editor.spriteBatch.End();
        }

        public void LoadTexture(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open);
            textures.Add(Texture2D.FromStream(Editor.graphics, stream));
            keyFrameLenghts.Add(3);

            animator.ChangeAnimation(new AnimationData(textures, keyFrameLenghts, true));
        }
    }
}