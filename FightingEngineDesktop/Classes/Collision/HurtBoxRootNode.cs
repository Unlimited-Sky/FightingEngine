using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FightingEngine.Gameplay;
using Microsoft.Xna.Framework;

namespace FightingEngine.Collision
{
    public class HurtBoxRootNode : CollisionRootNode
    {
        public HurtBoxData HurtBoxData;

        public HurtBoxRootNode(HurtBoxData hurtBoxData)
        {
            HurtBoxData = hurtBoxData;
        }
    }
}
