using FightingEngine.StateMachine;
using System;
using System.Collections.Generic;
using System.Runtime;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.StateMachine
{
    class StateMachine<T> where T : AState
    {
        private Stack<AState> _stack;

        public StateMachine()
        {
            _stack = new Stack<AState>();
        }

        public AState GetCurrentState()
        {
            return _stack.Peek();
        }
       
        public AState PopState()
        {
            AState result = _stack.Pop();
            result.Exit();
            return result;
        }

        public AState ChangeState(AState state)
        {
            AState result = PopState();
            PushState(state);
            return result;
        }

        public void PushState(AState state)
        {
            _stack.Push(state);
            state.Enter();
        }

        public void Tick()
        {
            GetCurrentState().Tick();
        }

        public void Draw()
        {
            GetCurrentState().Draw();
        }
    }
}
