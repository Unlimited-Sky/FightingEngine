using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightingEngine.Gameplay;
using Microsoft.Xna.Framework;

namespace FightingEngine.Collision
{
    public class HitBoxRootNode : CollisionRootNode
    {
        public HitBoxData HitBoxData;

        public HitBoxRootNode(HitBoxData hitBoxData)
        {
            HitBoxData = hitBoxData;
        }

        public HitBoxRootNode(HitBoxRootNode copy)
        {
            HitBoxData = copy.HitBoxData;

            foreach (SimpleRectNode node in copy.Children)
                Children.Add(node);
        }
    }

}
