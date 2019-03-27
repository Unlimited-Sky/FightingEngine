using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.Collision
{
    public class Rectangle
    {
        public Point TopLeft;
        public Point BottomRight;

        public int Top() { return TopLeft.Y; }
        public int Left() { return TopLeft.X; }
        public int Bottom() { return BottomRight.Y; }
        public int Right() { return BottomRight.X; }

        public Rectangle()
        {
            TopLeft = new Point(0, 0);
            BottomRight = new Point(0, 0);
        }

        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public Rectangle(int top, int left, int bottom, int right)
        {
            TopLeft = new Point(left, top);
            BottomRight = new Point(right, bottom);
        }

        //Returns true if a and b are touching (edges inclusive)
        static bool CheckCollision(Rectangle a, Rectangle b)
        {
            return !(b.Left() >= a.Right() || b.Right() <= a.Left() || b.Top() <= a.Bottom() || b.Bottom() >= a.Top());
        }

        //Returns true if a and b are touching (edges must overlap)
        static bool CheckIntersect(Rectangle a, Rectangle b)
        {
            return !(b.Left() > a.Right() || b.Right() < a.Left() || b.Top() < a.Bottom() || b.Bottom() > a.Top());
        }
    }
}
