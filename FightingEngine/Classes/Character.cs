using FightingEngine.Classes.Animation;
using FightingEngine.Classes.CharacterStates;
using FightingEngine.Classes.StateMachines;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace FightingEngine.Classes
{
    class Character : AActor
    {
        public Animator Animator { get; }
        private List<AnimationData> _animations;
        public StateMachine<ACharacterState> CharacterStateMachine;
        
        public Character(List<Texture2D> texs, List<int> lengths)
        {
            Animator = new Animator(new AnimationData(texs, lengths, true));
        }

        public override void Tick()
        {
            Animator.Tick();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            Animator.Draw(spriteBatch, position.ToVector2());        
        }
    }
}
