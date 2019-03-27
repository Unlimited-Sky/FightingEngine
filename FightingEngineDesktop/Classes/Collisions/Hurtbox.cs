using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace FightingEngine.Collision
{
    public class HurtBox : SimpleRect
    {
        public HurtBox()
        {
        }

        public HurtBox(Point topLeft, Point bottomRight) : base(topLeft, bottomRight)
        {
        }

        public HurtBox(int top, int left, int bottom, int right) : base(top, left, bottom, right)
        {
        }
    }
}
