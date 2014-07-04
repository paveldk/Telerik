namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class InfestationSpores : ISupplement
    {
        public void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement is InfestationSpores)
            {
                this.PowerEffect = 0;
                this.AggressionEffect = 0;
            }
        }

        public int PowerEffect
        {
            get
            {
                return -1;
            }
            set
            {

            }
        }

        public int HealthEffect
        {
            get;
            set;
        }

        public int AggressionEffect
        {
            get 
            {
                return 20;
            }
            set
            {

            }
        }
    }
}
