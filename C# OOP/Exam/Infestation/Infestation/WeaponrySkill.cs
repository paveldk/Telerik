namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class WeaponrySkill : ISupplement
    {
        public void ReactTo(ISupplement otherSupplement)
        {
 
        }

        public int PowerEffect
        {
            get;
            set;
        }

        public int HealthEffect
        {
            get;
            set;
        }

        public int AggressionEffect
        {
            get;
            set;
        }
    }
}
