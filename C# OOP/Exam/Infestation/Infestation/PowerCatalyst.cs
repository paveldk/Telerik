namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class PowerCatalyst : ISupplement
    {
        public void ReactTo(ISupplement otherSupplement)
        {
        }

        public int PowerEffect
        {
            get 
            { 
                return 3; 
            }
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
