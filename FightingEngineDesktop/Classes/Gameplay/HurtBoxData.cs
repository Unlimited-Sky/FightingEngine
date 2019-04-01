using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingEngine.Gameplay
{
    public class HurtBoxData
    {
        public bool ProjectileImmunity;
        public bool LowImmunity;

        public HurtBoxData(bool projectileImmunity, bool lowImmunity)
        {
            ProjectileImmunity = projectileImmunity;
            LowImmunity = lowImmunity;
        }
    }
}
