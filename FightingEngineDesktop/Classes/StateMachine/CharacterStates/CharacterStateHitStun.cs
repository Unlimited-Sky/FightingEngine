using FightingEngine.Actor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.StateMachine
{
    class CharacterStateHitStun : CharacterState
    {
        public CharacterStateHitStun(FightingEngine game, Character character) : base(game, character) { }
    }
}
