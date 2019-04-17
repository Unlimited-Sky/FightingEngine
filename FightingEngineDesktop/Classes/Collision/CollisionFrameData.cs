using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.Collision
{
    public class CollisionFrameData
    {
        public Dictionary<int, List<HurtBoxRootNode>> HurtBoxKeyFrameData { get; private set; }
        public Dictionary<int, List<HitBoxRootNode>> HitBoxKeyFrameData { get; private set; }
        public Dictionary<int, CharacterCollider> CharacterColliderFrameData { get; private set; }

        public CollisionFrameData()
        {
            HurtBoxKeyFrameData = new Dictionary<int, List<HurtBoxRootNode>>();
            HitBoxKeyFrameData = new Dictionary<int, List<HitBoxRootNode>>();
            CharacterColliderFrameData = new Dictionary<int, CharacterCollider>();
        }
    }
}
