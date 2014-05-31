namespace WarMachines.Machines
{
    using System;
    using Interfaces;
    using System.Text;

    public class Fighter : Machine, IFighter
    {
        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode, double healthpoints = 200) :
            base(name, healthpoints, attackPoints, defensePoints)
        {
            this.stealthMode = stealthMode;
        }

        public bool StealthMode
        {
            get
            {
                return this.stealthMode;
            }
        }

        public void ToggleStealthMode()
        {
            this.stealthMode = !stealthMode;
        } 

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.StealthMode)
            {
                result.AppendLine(" *Stealth: ON");
            }
            else
            {
                result.AppendLine(" *Stealth: OFF");
            }

            return base.ToString() + result;
        }
    }
}
