namespace Infestation
{
    class AggressionCatalyst : ISupplement
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
            get 
            {
                return 3;
            }
        }
    }
}
