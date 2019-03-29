using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace FightingEngine.Collision
{
    public class HurtBoxRootNode : CollisionRootNode
    {
        public bool ProjectileImmunity;
        public bool LowImmunity;

        public HurtBoxRootNode()
        {
        }
    }
}
