using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FightingEngine.Animation
{
    //An object which handles the logic for animations and frames
    public class Animator
    {
        public AnimationData AnimData { get; private set; }

        public int CurrentFrame { get; private set; }
        public bool IsPlaying { get; private set; }

        public bool GetIsPlaying()
        {
            return IsPlaying;
        }

        public void Resume()
        {
            IsPlaying = true;
        }

        public void Pause()
        {
            IsPlaying = false;
        }

        public void Stop()
        {
            Pause();
            CurrentFrame = 0;
        }

        public void Restart()
        {
            Resume();
            CurrentFrame = 0;
        }

        public void SetFrameToFirstOfKeyFrame(int keyFrame)
        {
            CurrentFrame = AnimData.GetFirstFrameOfKeyframe(keyFrame);
        }

        public void ChangeAnimation(AnimationData newAnimation)
        {
            AnimData = newAnimation;
            Restart();
        }

        public Animator(AnimationData animData)
        {
            AnimData = animData;
            IsPlaying = true;
            CurrentFrame = 0;
        }

        public Animator()
        {
            AnimData = null;
            IsPlaying = true;
            CurrentFrame = 0;
        }

        public void Tick()
        {
            if (!IsPlaying)
                return;

            CurrentFrame += 1;

            if (CurrentFrame >= AnimData.GetTotalFrames())
                if (AnimData.IsLooping)
                    CurrentFrame %= AnimData.GetTotalFrames();
                else
                    Stop();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(AnimData.GetTextureFromAnimationFrame(CurrentFrame), position, Color.White);
        }
    }
}
