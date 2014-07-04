namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    class Queen : Unit
    {
        const int QueenPower = 1;
        const int QueenAggression = 1;
        const int QueenHealth = 30;

        public Queen(string id) :
            base(id, UnitClassification.Psionic, Queen.QueenHealth, Queen.QueenPower, Queen.QueenAggression)
        {
        }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            bool attackUnit = false;
            if (this.Id != unit.Id)
            {
                attackUnit = true;
            }

            return attackUnit;
        }

        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, int.MaxValue, int.MaxValue, int.MaxValue);

            foreach (var unit in attackableUnits)
            {
                if (unit.Health < optimalAttackableUnit.Health)
                {
                    optimalAttackableUnit = unit;
                }
            }

            return optimalAttackableUnit;
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            var candidateUnits = units.Where((unit) => unit.Id != this.Id && this.UnitClassification == InfestationRequirements.RequiredClassificationToInfest(unit.UnitClassification));

            UnitInfo optimalInfestableUnit = new UnitInfo(null, Infestation.UnitClassification.Unknown, int.MaxValue, 0, 0);

            foreach (var unit in candidateUnits)
            {
                if (unit.Health < optimalInfestableUnit.Health)
                {
                    optimalInfestableUnit = unit;
                }
            }

            if (optimalInfestableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalInfestableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }
    }
}
