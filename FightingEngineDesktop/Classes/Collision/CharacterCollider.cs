using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace FightingEngine.Collision
{
    public class CharacterCollider : SimpleRect
    {
        public CharacterCollider()
        {
            TopLeft = new Point(-25, -25);
            BottomRight = new Point(25, 25);
        }

        public CharacterCollider(CharacterCollider other)
        {
            TopLeft = other.TopLeft;
            BottomRight = other.BottomRight;
        }

        public Point GetOrigin()
        {
            return new Point((TopLeft.X + BottomRight.X) / 2, BottomRight.Y);
        }

        public CharacterCollider(Point topLeft, Point bottomRight) : base(topLeft, bottomRight)
        {
        }

        public CharacterCollider(int top, int left, int bottom, int right) : base(top, left, bottom, right)
        {
        }
    }
}
