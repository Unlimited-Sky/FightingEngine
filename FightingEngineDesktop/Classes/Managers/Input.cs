using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine
{
    [Flags]
    public enum Input
    {
        //16 Bits in an int
        Up = 1 << 0,
        Down = 1 << 1,
        Left = 1 << 2,
        Right = 1 << 3,
        A = 1 << 4,
        B = 1 << 5,
        C = 1 << 6,
        S = 1 << 7,

        Start = 1 << 8,
        Select = 1 << 9
    }
}
