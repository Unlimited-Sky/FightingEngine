using FightingEngine.StateMachine;

namespace FightingEngine.StateMachine
{
    public abstract class ACharacterState : AState
    { 
        public ACharacterState(FightingEngine game) : base(game) { }
    }
}
