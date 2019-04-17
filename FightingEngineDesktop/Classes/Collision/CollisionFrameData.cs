using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.Collision
{
    public class CollisionFrameData
    {
        public Dictionary<int, List<HurtBoxRootNode>> hurtBoxKeyFrameData { get; private set; }
        public Dictionary<int, List<HitBoxRootNode>> hitBoxKeyFrameData { get; private set; }
        public Dictionary<int, CharacterCollider> characterColliderFrameData { get; private set; }

        public CollisionFrameData()
        {
            hurtBoxKeyFrameData = new Dictionary<int, List<HurtBoxRootNode>>();
            hitBoxKeyFrameData = new Dictionary<int, List<HitBoxRootNode>>();
            characterColliderFrameData = new Dictionary<int, CharacterCollider>();
        }
    }
}
