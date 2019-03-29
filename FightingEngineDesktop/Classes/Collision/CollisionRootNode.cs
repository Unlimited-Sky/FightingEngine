using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.Collision
{
    public class CollisionRootNode
    {
        private List<SimpleRectNode> _children;

        public CollisionRootNode()
        {
            _children = new List<SimpleRectNode>();
        }

        public CollisionRootNode(List<SimpleRectNode> children)
        {
            _children = children;
        }

        public List<SimpleRectNode> GetChildren()
        {
            return _children;
        }
    }
}
