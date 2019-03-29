using FightingEngine;
using FightingEngine.Animation;
using FightingEngine.Collision;
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
        public List<int> keyFrameLengths;
        public FightingEditorForm editorForm;

        public Dictionary<int, List<HurtBoxRootNode>> hurtBoxKeyFrameData;
        public Dictionary<int, List<HitBoxRootNode>> hitBoxKeyFrameData;
        public CharacterCollider characterCollider;

        public SimpleShapeRenderer ssr;

        public float renderScale = 3.0f;
       
        protected override void Initialize()
        {
            base.Initialize();

            animator = new Animator();

            textures = new List<Texture2D>();
            keyFrameLengths = new List<int>();

            ssr = new SimpleShapeRenderer(Editor.spriteBatch, Editor.graphics);

            //TODO lock to 60fps

            hitBoxKeyFrameData = new Dictionary<int, List<HitBoxRootNode>>();
            hurtBoxKeyFrameData = new Dictionary<int, List<HurtBoxRootNode>>();
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

            Vector2 center = new Vector2(Editor.graphics.Viewport.Width / 2, Editor.graphics.Viewport.Height / 2);

            base.Draw();

            Editor.spriteBatch.Begin();

            if (animator != null && animator.AnimData != null)
            {
                int keyFrameIndex = animator.GetAnimKeyFrameIndex();
                animator.Draw(Editor.spriteBatch, center);
                
                //Draw frame counter
                Editor.spriteBatch.DrawString(Editor.Font, animator.CurrentFrame.ToString(), new Vector2(
                (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString(animator.CurrentFrame.ToString()).X / 2),
                (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2)),
                Color.White);


                if (hitBoxKeyFrameData.ContainsKey(keyFrameIndex))
                {
                    foreach (HitBoxRootNode root in hitBoxKeyFrameData[keyFrameIndex])
                        ssr.DrawCollisions(root);

                }

                if (hurtBoxKeyFrameData.ContainsKey(keyFrameIndex))
                {
                    foreach (HurtBoxRootNode root in hurtBoxKeyFrameData[keyFrameIndex])
                        ssr.DrawCollisions(root);
                }
            }
            Editor.spriteBatch.End();
        }

        private void InitAnimator()
        {
            bool lastPlaying = animator.IsPlaying;
            animator.ChangeAnimation(new AnimationData(textures, keyFrameLengths, true));

            if (lastPlaying == false && animator.IsPlaying)
                animator.Pause();
        }

        public void LoadTexture(string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open);
            textures.Add(Texture2D.FromStream(Editor.graphics, stream));
            keyFrameLengths.Add(3);
            InitAnimator();
        }

        public void RemoveKeyFrame(int index)
        {
            keyFrameLengths.RemoveAt(index);
            textures.RemoveAt(index);
            InitAnimator();
        }

        public void SwapKeyFrames(int i1, int i2)
        {
            int tempLength = keyFrameLengths[i1];
            keyFrameLengths[i1] = keyFrameLengths[i2];
            keyFrameLengths[i2] = tempLength;

            Texture2D tempTex = textures[i1];
            textures[i1] = textures[i2];
            textures[i2] = tempTex;

            InitAnimator();
        }

        public void AdjustKeyFrameLength(int index, int newLength)
        {
            keyFrameLengths[index] = newLength;

            InitAnimator();
        }

        public void AddRootHitBox(int keyFrame)
        {
            if (hitBoxKeyFrameData.ContainsKey(keyFrame))
            {
                hitBoxKeyFrameData[keyFrame].Add(new HitBoxRootNode());
            }
            else
            {
                hitBoxKeyFrameData.Add(keyFrame, new List<HitBoxRootNode> { new HitBoxRootNode() });
            }

        }

        public void AddHitBox()
        {
            //TODO
        }

        public void DeleteHitBox()
        {
            //TODO
        }

        public void AddRootHurtBox(int keyFrame)
        {
            if (hurtBoxKeyFrameData.ContainsKey(keyFrame))
            {
                hurtBoxKeyFrameData[keyFrame].Add(new HurtBoxRootNode());
            }
            else
            {
                hurtBoxKeyFrameData.Add(keyFrame, new List<HurtBoxRootNode> { new HurtBoxRootNode() });
            }
        }


        public void AddHurtBox()
        {
            //TODO
        }

        public void DeleteHurtBox()
        {
            //TODO
        }
    }
}