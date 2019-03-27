using FightingEngine.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.StateMachine
{
    class CharacterStateFactory
    {
        private Character _character;
        private FightingEngine _game;
        private Dictionary<Type, CharacterState> _states;

        public CharacterStateFactory(FightingEngine game, Character character)
        {
            _game = game;
            _character = character;
            _states = new Dictionary<Type, CharacterState>();
        }

        public CS Get<CS>() where CS : CharacterState
        {
            Type type = typeof(CS);
            if (_states.ContainsKey(type))
                return (CS)_states[type];
            else
            {
                CS newState = (CS)type.GetConstructor(new[] { typeof(FightingEngine), typeof(Character) }).Invoke(new object[] { _game, _character });
                _states[type] = newState;
                return newState;
            }
        }
    }
}
