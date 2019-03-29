using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace FightingEngine.Collision
{
    public class HitBoxRootNode : CollisionRootNode
    {
        public int HitStop;
        public int HitStun;
        public int BlockStun;
        public int Damage;
        //public ??? HitResult; //TODO
        //public ??? Juggle;
        
        //Cancels + cancels routes TODO

        public HitBoxRootNode()
        {
        }

    }
}
