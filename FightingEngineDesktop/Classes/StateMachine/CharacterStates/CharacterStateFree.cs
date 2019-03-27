using FightingEngine.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.StateMachine
{
    class CharacterStateFree : CharacterState
    {
        public CharacterStateFree(FightingEngine game, Character character) : base(game, character) { }
    }
}
