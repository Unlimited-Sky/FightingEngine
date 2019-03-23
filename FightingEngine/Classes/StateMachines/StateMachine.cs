﻿using FightingEngine.Classes.StateMachines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.Classes.StateMachines
{
    class StateMachine<T> where T : AState
    {
        private Stack<AState> _states;

        public AState GetCurrentState()
        {
            return _states.Peek();
        }

        public void PushState(AState state)
        {
            _states.Push(state);
            state.Enter();
        }

        public AState PopState()
        {
            AState result = _states.Pop();
            result.Exit();
            return result;
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
