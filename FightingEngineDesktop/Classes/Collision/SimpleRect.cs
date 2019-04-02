using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.Collision
{
    public class SimpleRect
    {
        public Point TopLeft;
        public Point BottomRight;

        public int Top() { return TopLeft.Y; }
        public int Left() { return TopLeft.X; }
        public int Bottom() { return BottomRight.Y; }
        public int Right() { return BottomRight.X; }

        public SimpleRect()
        {
            TopLeft = new Point(0, 0);
            BottomRight = new Point(0, 0);
        }

        public SimpleRect(Point topLeft, Point bottomRight)
        {
            TopLeft = topLeft;
            BottomRight = bottomRight;
        }

        public SimpleRect(int top, int left, int bottom, int right)
        {
            TopLeft = new Point(left, top);
            BottomRight = new Point(right, bottom);
        }

        //Returns true if a and b are touching (edges inclusive)
        public static bool CheckCollision(SimpleRect a, SimpleRect b)
        {
            return !(b.Left() >= a.Right() || b.Right() <= a.Left() || b.Top() <= a.Bottom() || b.Bottom() >= a.Top());
        }

        //Returns true if a and b are touching (edges must overlap)
        public static bool CheckIntersect(SimpleRect a, SimpleRect b)
        {
            return !(b.Left() > a.Right() || b.Right() < a.Left() || b.Top() < a.Bottom() || b.Bottom() > a.Top());
        }

        public SimpleRect WithOffset(Point offset)
        {
            return new SimpleRect(TopLeft + offset, BottomRight + offset);
        }
    }
}
