using FightingEngine;
using FightingEngine.Animation;
using FightingEngine.Collision;
using FightingEngine.Gameplay;
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

        private int renderScale = 2;
        private int AxisLength = 50;

        public bool ShowOrigin = true;
        public bool ShowFrame = true;

        private SELECTEDMODE selectedMode = SELECTEDMODE.NONE;
        private int selectedRootIndex = 0;
        private int selectedIndex = 0;
        private int selectedKeyFrame = 0;

        public Point CharacterPosition;

        protected override void Initialize()
        {
            base.Initialize();

            animator = new Animator();
            textures = new List<Texture2D>();
            keyFrameLengths = new List<int>();

            ssr = new SimpleShapeRenderer(Editor.spriteBatch, Editor.graphics);

            Editor.Cam.GetZoom = renderScale;

            hitBoxKeyFrameData = new Dictionary<int, List<HitBoxRootNode>>();
            hurtBoxKeyFrameData = new Dictionary<int, List<HurtBoxRootNode>>();

            CharacterPosition = new Point(Editor.graphics.Viewport.Width / 2, Editor.graphics.Viewport.Height / 2);
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

            Editor.BeginCamera2D();

            if (animator != null && animator.AnimData != null)
            {
                int keyFrameIndex = animator.GetAnimKeyFrameIndex();
                animator.Draw(Editor.spriteBatch, CharacterPosition.ToVector2());

                DrawFrameCounter();
                DrawCollisionBoxes(keyFrameIndex);
                DrawSelectedCollisionBoxes();
            }

            DrawOrigin();

            Editor.EndCamera2D();
        }

        private void DrawFrameCounter()
        {
            if (ShowFrame)
            {
                Editor.spriteBatch.DrawString(Editor.Font, animator.CurrentFrame.ToString(), new Vector2(
                    (Editor.graphics.Viewport.Width / 2) - (Editor.Font.MeasureString(animator.CurrentFrame.ToString()).X / 2),
                    (Editor.graphics.Viewport.Height / 2) - (Editor.FontHeight / 2)),
                    Color.White);
            }
        }

        private void DrawCollisionBoxes(int keyFrameIndex)
        {
            if (hitBoxKeyFrameData.ContainsKey(keyFrameIndex))
            {
                foreach (HitBoxRootNode root in hitBoxKeyFrameData[keyFrameIndex])
                    ssr.DrawCollisions(root, CharacterPosition);
            }

            if (hurtBoxKeyFrameData.ContainsKey(keyFrameIndex))
            {
                foreach (HurtBoxRootNode root in hurtBoxKeyFrameData[keyFrameIndex])
                    ssr.DrawCollisions(root, CharacterPosition);
            }
        }
        
        private void DrawSelectedCollisionBoxes()
        {
            //TODO THIS FUNCTION
            if (selectedMode == SELECTEDMODE.NONE)
                return;
            else if (selectedMode == SELECTEDMODE.HIT_ROOT)
            {
                foreach (SimpleRectNode node in hitBoxKeyFrameData[selectedKeyFrame][selectedRootIndex].Children)
                    drawSelectedCollisionBox(node);
            }
            else if (selectedMode == SELECTEDMODE.HURT_ROOT)
            {
                foreach (SimpleRectNode node in hurtBoxKeyFrameData[selectedKeyFrame][selectedRootIndex].Children)
                    drawSelectedCollisionBox(node);
            }
            else if (selectedMode == SELECTEDMODE.HIT_BOX)
            {
                drawSelectedCollisionBox(hitBoxKeyFrameData[selectedKeyFrame][selectedRootIndex].Children[selectedIndex]);
            }
            else if (selectedMode == SELECTEDMODE.HURT_BOX)
            {
                drawSelectedCollisionBox(hurtBoxKeyFrameData[selectedKeyFrame][selectedRootIndex].Children[selectedIndex]);
            }
        }

        private void drawSelectedCollisionBox(SimpleRectNode node)
        {
            SimpleRect rect = node.WithOffset(CharacterPosition);
            ssr.DrawRect(rect.TopLeft, rect.BottomRight, Color.Yellow, false, 2);
        }

        private void DrawOrigin()
        {
            if (ShowOrigin)
            {
                ssr.DrawLine(new Point(CharacterPosition.X, CharacterPosition.Y),
                    new Point(CharacterPosition.X + AxisLength, CharacterPosition.Y), Color.Yellow);
                ssr.DrawLine(new Point(CharacterPosition.X, CharacterPosition.Y + AxisLength),
                    new Point(CharacterPosition.X, CharacterPosition.Y), Color.Yellow);
            }
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
            hurtBoxKeyFrameData.Remove(index);
            hitBoxKeyFrameData.Remove(index);
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

        public void AddRootHitBox(int keyFrame, HitBoxData data)
        {
            if (hitBoxKeyFrameData.ContainsKey(keyFrame))
            {
                hitBoxKeyFrameData[keyFrame].Add(new HitBoxRootNode(data));
            }
            else
            {
                hitBoxKeyFrameData.Add(keyFrame, new List<HitBoxRootNode> { new HitBoxRootNode(data) });
            }
        }

        public void AddHitBox(int keyFrame, int rootIndex, int top, int left, int bottom, int right)
        {
            hitBoxKeyFrameData[keyFrame][rootIndex].AddChild(top, left, bottom, right);
        }

        public void DeleteHitBox()
        {
            //TODO
        }

        public void AddRootHurtBox(int keyFrame, HurtBoxData data)
        {
            if (hurtBoxKeyFrameData.ContainsKey(keyFrame))
            {
                hurtBoxKeyFrameData[keyFrame].Add(new HurtBoxRootNode(data));
            }
            else
            {
                hurtBoxKeyFrameData.Add(keyFrame, new List<HurtBoxRootNode> { new HurtBoxRootNode(data) });
            }
        }

        public void AddHurtBox(int keyFrame, int rootIndex, int top, int left, int bottom, int right)
        {
            hurtBoxKeyFrameData[keyFrame][rootIndex].AddChild(top, left, bottom, right);
        }

        public void DeleteHurtBox()
        {
            //TODO
        }

        public void SelectRootHitbox(int keyFrame, int index)
        {
            selectedMode = SELECTEDMODE.HIT_ROOT;
            selectedKeyFrame = keyFrame;
            selectedRootIndex = index;
        }

        public void SelectRootHurtbox(int keyFrame, int index)
        {
            selectedMode = SELECTEDMODE.HURT_ROOT;
            selectedKeyFrame = keyFrame;
            selectedRootIndex = index;
        }

        public void SelectHitbox(int keyFrame, int rootIndex, int index)
        {
            selectedMode = SELECTEDMODE.HIT_BOX;
            selectedKeyFrame = keyFrame;
            selectedRootIndex = rootIndex;
            selectedIndex = index;
        }

        public void SelectHurtbox(int keyFrame, int rootIndex, int index)
        {
            selectedMode = SELECTEDMODE.HURT_BOX;
            selectedKeyFrame = keyFrame;
            selectedRootIndex = rootIndex;
            selectedIndex = index;
        }

        public void DeselectCollisions()
        {
            selectedMode = SELECTEDMODE.NONE;
        }

        public void ResizeBox(int top, int left, int bottom, int right)
        {
            SimpleRectNode node = GetSelectedCollisionBoxNode();
            node.TopLeft = new Point(left, top);
            node.BottomRight = new Point(right, bottom);
        }

        public void ReInitHitBoxRoot(HitBoxData newData)
        {
            hitBoxKeyFrameData[selectedKeyFrame][selectedRootIndex].HitBoxData = newData;
        }

        public void ReInitHurtBoxRoot(HurtBoxData newData)
        {
            hurtBoxKeyFrameData[selectedKeyFrame][selectedRootIndex].HurtBoxData = newData;
        }

        public SimpleRectNode GetSelectedCollisionBoxNode()
        {
            if (selectedMode == SELECTEDMODE.HIT_BOX)
                return hitBoxKeyFrameData[selectedKeyFrame][selectedRootIndex].Children[selectedIndex];
            else if (selectedMode == SELECTEDMODE.HURT_BOX)
                return hurtBoxKeyFrameData[selectedKeyFrame][selectedRootIndex].Children[selectedIndex];
            else
                throw new NotImplementedException();
        }

        public HitBoxData GetHitboxRootData()
        {
            return hitBoxKeyFrameData[selectedKeyFrame][selectedRootIndex].HitBoxData;
        }

        public HurtBoxData GetHurtboxRootData()
        {
            return hurtBoxKeyFrameData[selectedKeyFrame][selectedRootIndex].HurtBoxData;
        }

    }

    public enum SELECTEDMODE
    {
        NONE,
        CHAR_COLLIDER,
        HIT_ROOT,
        HURT_ROOT,
        HIT_BOX,
        HURT_BOX
    }
}