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

        public SimpleRectNode(CollisionRootNode parent)
        {
            Parent = parent;
        }
    }
}
