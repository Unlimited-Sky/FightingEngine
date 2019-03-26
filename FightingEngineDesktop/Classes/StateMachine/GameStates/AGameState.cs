using FightingEngine.StateMachine;

namespace FightingEngine.StateMachine
{
    internal abstract class AGameState : AState
    {
        public AGameState(FightingEngine game) : base(game) { }
    }
}
