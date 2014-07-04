namespace WarMachines.Machines
{
    using System;
    using System.Linq;
    using Interfaces;
    using System.Text;
    using System.Collections.Generic;

    public class Pilot : IPilot
    {
        private HashSet<IMachine> machines = new HashSet<IMachine>();

        public Pilot(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get;
            set;
        }

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder pilotReport = new StringBuilder();

            if (this.machines.Count == 1)
            {
                pilotReport.Append(" - 1 machine");
                pilotReport.Append(System.Environment.NewLine);
            }
            else if (this.machines.Count > 1)
            {
                pilotReport.Append(" - " + this.machines.Count + " machines");
                pilotReport.Append(System.Environment.NewLine);
            }
            else
            {
                pilotReport.Append(" - no machines");
            }

            foreach (var machine in machines.OrderBy(machine => machine.HealthPoints).ThenBy(machine => machine.Name))
            {
                pilotReport.Append("- ");
                pilotReport.Append(machine.Name);
                pilotReport.Append(System.Environment.NewLine);
                pilotReport.Append(machine.ToString());
            }

            return this.ToString() + pilotReport.ToString().TrimEnd();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
