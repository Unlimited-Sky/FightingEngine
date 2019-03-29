using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.Collision
{
    public class CollisionRootNode
    {
        public List<SimpleRectNode> Children;

        public CollisionRootNode()
        {
            Children = new List<SimpleRectNode>();
        }

        public CollisionRootNode(List<SimpleRectNode> children)
        {
            Children = children;
        }

    }
}
