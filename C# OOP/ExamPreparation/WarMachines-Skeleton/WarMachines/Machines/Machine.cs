namespace WarMachines.Machines
{
    using System;
    using Interfaces;
    using System.Text;
    using System.Collections.Generic;

    public class Machine : IMachine
    {
        private IList<string> targets = new List<string>();

        public Machine(string name, double healthPoints, double attackPoints, double defensePoints)
        {
            this.Name = name;
            this.HealthPoints = healthPoints;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
        }

        public string Name
        {
            get;
            set;
        }

        public IPilot Pilot
        {
            get;
            set;
        }

        public double HealthPoints
        {
            get;
            set;
        }

        public double AttackPoints
        {
            get;
            set;
        }

        public double DefensePoints
        {
            get;
            set;
        }

        public System.Collections.Generic.IList<string> Targets
        {
            get { return this.targets; }
        }

        public void Attack(string target)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(" *Type: " + GetType().Name);
            result.AppendLine(" *Health: " + this.HealthPoints);
            result.AppendLine(" *Attack: " + this.AttackPoints);
            result.AppendLine(" *Defense: " + this.DefensePoints);

            if (this.Targets.Count == 0)
            {
                result.AppendLine(" *Targets: None");
            }
            else
            {
                string targets = string.Empty;
                foreach (var target in this.Targets)
                {
                    targets = targets + target + ", ";
                }

                targets = targets.TrimEnd(' ');
                targets = targets.TrimEnd(',');
                result.AppendLine(" *Targets: " + targets);
            }

            return result.ToString();
        }
    }
}
