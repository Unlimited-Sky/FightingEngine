using FightingEngine.StateMachine;

namespace FightingEngine.StateMachine
{
    public class CharacterState : AState
    {
        protected Character _character;

        public CharacterState(FightingEngine game, Character character) : base(game)
        {
            _character = character;
        }

        public override void Draw()
        {
            _character.StandardDraw();
        }

        public override void Enter()
        {
            //throw new System.NotImplementedException();
        }

        public override void Exit()
        {
            //throw new System.NotImplementedException();
        }

        public override void Tick()
        {
            _character.StandardTick();
        }
    }
}
