using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.StateMachine
{
    public abstract class AState
    {
        public abstract void Enter();

        public abstract void Exit();

        public abstract void Tick();

        public abstract void Draw();
    }
}
