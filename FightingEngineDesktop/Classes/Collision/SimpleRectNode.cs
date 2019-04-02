using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.Collision
{
    public class SimpleRectNode : SimpleRect
    {
        public CollisionRootNode Parent { get; private set; }

        //public SimpleRectNode(CollisionRootNode parent)
        //{
        //    Parent = parent;
        //}

        public SimpleRectNode(CollisionRootNode parent, int top, int left, int bottom, int right) : 
            base(top, left, bottom, right)
        {
            Parent = parent;
        }
    }
}
