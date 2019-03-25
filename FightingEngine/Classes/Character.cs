using FightingEngine.Animation;
using FightingEngine.StateMachine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace FightingEngine
{
    public class Character : AActor
    {
        public Animator Animator { get; private set; }
        private List<AnimationData> _animations;
        private StateMachine<CharacterState> _stateMachine;
        
        public Character(FightingEngine game, List<Texture2D> texs, List<int> lengths) : base(game)
        {
            Animator = new Animator(new AnimationData(texs, lengths, true));

            _stateMachine = new StateMachine<CharacterState>();
            _stateMachine.PushState(new CharacterStateFree(_game, this));
        }

        //Called from AActor
        public override void Tick()
        {
            _stateMachine.Tick();
        }

        //Called from AActor
        public override void Draw(SpriteBatch spriteBatch)
        {
            _stateMachine.Draw();
        }

        public void StandardTick()
        {
            Animator.Tick();
        }

        public void StandardDraw()
        {
            Animator.Draw(_game.spriteBatch, position.ToVector2());
        }

        public void PopState()
        {
            _stateMachine.PopState();
        }

        public void PushState(CharacterState state)
        {
            _stateMachine.PushState(state);
        }           
    }
}
