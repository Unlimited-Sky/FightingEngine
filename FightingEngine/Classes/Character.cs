using FightingEngine.Classes.Animation;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace FightingEngine.Classes
{
    class Character : Actor
    {
        public Animator Animator { get; }

        public Character(List<Texture2D> texs, List<int> lengths)
        {
            Animator = new Animator(new AnimationData(texs, lengths, true));
        }

        public override void Tick()
        {
            Animator.Tick();
        }
    }
}
