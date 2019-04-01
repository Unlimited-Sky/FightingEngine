using FightingEngine.Gameplay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.StateMachine
{
    public class CharacterStateHitStop : CharacterState
    {

        private int _stopFrames = 0;

        public CharacterStateHitStop(FightingEngine game, Character character) : base(game, character) { }

        public CharacterStateHitStop(FightingEngine game, Character character, int numFrames) : base(game, character)
        {
            _stopFrames = numFrames;
        }

        public void SetStopFrames(int frames)
        {
            _stopFrames = frames;
        }

        public override void Enter()
        {
            _character.Animator.Pause();
        }

        public override void Exit()
        {
            _character.Animator.Resume();
        }

        public override void Tick()
        {
            _stopFrames -= 1;

            if (_stopFrames <= 0)
                _character.PopState();
        }

    }
}
