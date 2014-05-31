namespace Infestation
{
    class HealthCatalyst : ISupplement
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
            get 
            {
                return 3;
            }
        }

        public int AggressionEffect
        {
            get;
            set;
        }
    }
}
