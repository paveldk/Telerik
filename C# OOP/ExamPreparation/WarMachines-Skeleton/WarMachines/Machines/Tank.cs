namespace WarMachines.Machines
{
    using System;
    using Interfaces;
    using System.Text;
    using System.Collections.Generic;

    public class Tank : Machine, ITank
    {
        private bool defenceMode;

        public Tank(string name, double attackPoints, double defensePoints, double healthpoints = 100) :
            base(name, healthpoints, attackPoints, defensePoints)
        {
            this.ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get
            {
                return this.defenceMode;
            }
        }

        public void ToggleDefenseMode()
        {
            this.defenceMode = !defenceMode;
            if (defenceMode)
            {
                this.DefensePoints += 30;
                this.AttackPoints -= 40;
            }
            else
            {
                this.DefensePoints -= 30;
                this.AttackPoints += 40;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.DefenseMode)
            {
                result.AppendLine(" *Defense: ON");
            }
            else
            {
                result.AppendLine(" *Defense: OFF");
            }

            return base.ToString() + result;
        }
    }
}
