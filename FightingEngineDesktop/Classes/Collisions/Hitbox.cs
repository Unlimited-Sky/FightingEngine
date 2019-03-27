using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace FightingEngine.Collision
{
    public class HitBox : SimpleRect
    {
        public HitBox()
        {
        }

        public HitBox(Point topLeft, Point bottomRight) : base(topLeft, bottomRight)
        {
        }

        public HitBox(int top, int left, int bottom, int right) : base(top, left, bottom, right)
        {
        }
    }
}
