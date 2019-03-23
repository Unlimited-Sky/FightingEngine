using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.StateMachine
{
    public abstract class AState
    {
        protected FightingEngine _game;

        public AState(FightingEngine game)
        {
            _game = game;
        }

        public abstract void Enter();

        public abstract void Exit();

        public abstract void Tick();

        public abstract void Draw();
    }
}
