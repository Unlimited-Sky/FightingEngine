using System.Linq;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Graphics;

namespace FightingEngine.Classes.Animation
{
    //Holds animation & key frame data to be used by the Animator class
    //Along with useful helper functions
    class AnimationData
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

        private int GetKeyFrameFromAnimationFrame(int frame)
        {
            //TODO: OPTIMIZE THIS
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

    }
}
