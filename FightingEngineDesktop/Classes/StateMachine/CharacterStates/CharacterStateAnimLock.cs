using FightingEngine.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.StateMachine
{
    class CharacterStateAnimLock : CharacterState
    {
        public CharacterStateAnimLock(FightingEngine game, Character character) : base(game, character) { }
    }
}
