namespace WarMachines.Engine
{
    using System.Collections.Generic;
    using WarMachines.Interfaces;
    using WarMachines.Machines;

    public class MachineFactory : IMachineFactory
    {
        private HashSet<string> usedNames = new HashSet<string>();

        private void CheckForDublicates(string name)
        {
            if (usedNames.Contains(name))
            {
                throw new System.Exception("Dublicate names aren't allowed!");
            }
        }

        public IPilot HirePilot(string name)
        {
            CheckForDublicates(name);
            usedNames.Add(name);
            return new Pilot(name);      
        }

        public ITank ManufactureTank(string name, double attackPoints, double defensePoints)
        {
            CheckForDublicates(name);
            usedNames.Add(name);
            return new Tank(name, attackPoints, defensePoints);
        }

        public IFighter ManufactureFighter(string name, double attackPoints, double defensePoints, bool stealthMode)
        {
            CheckForDublicates(name);
            usedNames.Add(name);
            return new Fighter(name, attackPoints, defensePoints, stealthMode);
        }
    }
}
