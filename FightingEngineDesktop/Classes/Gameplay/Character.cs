using FightingEngine.Animation;
using FightingEngine.Collision;
using FightingEngine.StateMachine;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;

namespace FightingEngine.Gameplay
{
    public class Character : AActor
    {
        public Animator Animator { get; private set; }
        public CharacterCollider CharacterCollider { get; private set; }
        //private List<AnimationData> _animations;
        private StateMachine<CharacterState> _stateMachine;
        private CharacterStateFactory _characterStateFactory;
        
        public Character(FightingEngine game, List<Texture2D> texs, List<int> lengths) : base(game)
        {
            Animator = new Animator(new AnimationData(texs, lengths, true));
            _characterStateFactory = new CharacterStateFactory(_game, this);

            _stateMachine = new StateMachine<CharacterState>();
            _stateMachine.PushState(_characterStateFactory.Get<CharacterStateFree>());
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

        public void PushState<CS>(int param = 0) where CS : CharacterState
        {
            CS state = _characterStateFactory.Get<CS>();
            _stateMachine.PushState(state);

            switch (state)
            {
                case CharacterStateAnimLock cs:
                    break;
                case CharacterStateBlockStun cs:
                    break;
                case CharacterStateFree cs:
                    break;
                case CharacterStateHitStop cs:
                    cs.SetStopFrames(param);
                    break;
                case CharacterStateHitStun cs:
                    break;
                default:
                    throw new System.NotImplementedException();           
            }          
        }
    }
}
