using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace FightingEngine.Classes.Animation
{
    //An object which handles animations. It itself doesnt draw, but only handles the logic for frames.
    class Animator : RenderableObject
    {
        private AnimationData AnimData;

        private int _currentFrame = 0;
        private bool _isPlaying = true;

        public bool GetIsPlaying()
        {
            return _isPlaying;
        }

        public void Play()
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
            Play();
            _currentFrame = 0;
        }

        public Animator(AnimationData animData)
        {
            AnimData = animData;
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

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(AnimData.GetTextureFromAnimationFrame(_currentFrame), _position.ToVector2(), Color.White);
        }
    }
}
