using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FightingEngine.Animation
{
    //An object which handles the logic for animations and frames
    public class Animator
    {
        public AnimationData AnimData { get; private set; }

        private int _currentFrame = 0;
        private bool _isPlaying = true;

        public bool GetIsPlaying()
        {
            return _isPlaying;
        }

        public void Resume()
        {
            _isPlaying = true;
        }

        public void Pause()
        {
            _isPlaying = false;
        }

        public void Stop()
        {
            Pause();
            _currentFrame = 0;
        }

        public void Restart()
        {
            Resume();
            _currentFrame = 0;
        }

        public void ChangeAnimation(AnimationData newAnimation)
        {
            AnimData = newAnimation;
            Restart();
        }

        public Animator(AnimationData animData)
        {
            AnimData = animData;
        }

        public Animator()
        {
            AnimData = null;
        }

        public void Tick()
        {
            if (!_isPlaying)
                return;

            _currentFrame += 1;

            if (_currentFrame >= AnimData.GetTotalFrames())
                if (AnimData.IsLooping)
                    _currentFrame %= AnimData.GetTotalFrames();
                else
                    Stop();
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(AnimData.GetTextureFromAnimationFrame(_currentFrame), position, Color.White);
        }
    }
}
