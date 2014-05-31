namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Weapon : ISupplement
    {
        public void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is WeaponrySkill)
            {
                this.PowerEffect = 10;
                this.AggressionEffect = 3;
            }
        }

        public int PowerEffect
        {
            get;
            private set;
        }

        public int HealthEffect
        {
            get;
            private set;
        }

        public int AggressionEffect
        {
            get;
            private set;
        }
    }
}
