using System.Linq;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace FightingEngine.Animation
{
    //Holds animation & key frame data to be used by the Animator class
    //Along with useful helper functions
    public class AnimationData
    {
        private List<int> _keyFrameLengths;
        private List<Texture2D> _textures;

        public bool IsLooping { get; }

        public AnimationData(List<Texture2D> textures, List<int> keyFrameLengths, bool isLooping)
        {
            _textures = textures;
            _keyFrameLengths = keyFrameLengths;
            IsLooping = isLooping;
        }

        public int GetTotalFrames()
        {
           return _keyFrameLengths.AsQueryable().Sum();
        }

        public int GetFramesRemaining(int currentFrame)
        {
            if (IsLooping)
                return 0;
            else
                return GetTotalFrames() - currentFrame;
        }

        private int GetKeyFrameFromAnimationFrame(int frame)
        {
            //TODO: OPTIMIZE THIS?
            int sum = 0;
            int keyFrame = 0;

            foreach (int length in _keyFrameLengths)
            {
                sum += length;
                if (sum >= frame) break;
                else keyFrame += 1;
            }

            return keyFrame;
        }

        public Texture2D GetTextureFromAnimationFrame(int frame)
        {
            return _textures[GetKeyFrameFromAnimationFrame(frame)];
        }

        public int GetNextKeyFrameFromFrame(int frame)
        {
            return Math.Min(GetNumKeyFrames(), GetKeyFrameFromAnimationFrame(frame) + 1);
        }

        public int GetPreviousKeyFrameFromFrame(int frame)
        {
            return Math.Max(GetNumKeyFrames(), GetKeyFrameFromAnimationFrame(frame) - 1);
        }

        public int GetNumKeyFrames()
        {
            return _keyFrameLengths.Count();
        }

        public int GetFirstFrameOfKeyframe(int keyFrame)
        {
            return _keyFrameLengths.Take(keyFrame).Sum();
        }

    }
}
