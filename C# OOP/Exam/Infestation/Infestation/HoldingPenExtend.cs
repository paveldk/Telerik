namespace Infestation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class HoldingPenExtend : HoldingPen
    {
        protected override void ExecuteAddSupplementCommand(string[] commandWords)
        {
            var unit = GetUnit(commandWords[2]);
            switch (commandWords[1])
            {
                case "AggressionCatalyst" :
                    unit.AddSupplement(new AggressionCatalyst());
                    break;
                case "PowerCatalyst":
                    unit.AddSupplement(new PowerCatalyst());
                    break;
                case "HealthCatalyst":
                    unit.AddSupplement(new HealthCatalyst());
                    break;
                case "Weapon":
                    unit.AddSupplement(new Weapon());
                    break;
                default:
                    break;
            }
        }

        protected override void ExecuteInsertUnitCommand(string[] commandWords)
        {
            switch (commandWords[1])
            {
                case "Tank":
                    var tank = new Tank(commandWords[2]);
                    this.InsertUnit(tank);
                    break;
                case "Marine":
                    var marine = new Marine(commandWords[2]);
                    marine.AddSupplement(new WeaponrySkill());
                    this.InsertUnit(marine);
                    break;
                case "Parasite":
                    var parasite = new Parasite(commandWords[2]);                  
                    this.InsertUnit(parasite);
                    break;
                case "Queen":
                    var queen = new Queen(commandWords[2]);
                    this.InsertUnit(queen);
                    break;
                default:
                    base.ExecuteInsertUnitCommand(commandWords);
                    break;
            }           
        }

        protected override void ProcessSingleInteraction(Interaction interaction)
        {
            switch (interaction.InteractionType)
            {
                case InteractionType.Infest:
                    Unit targetUnit = this.GetUnit(interaction.TargetUnit);


                    if ((targetUnit.UnitClassification == UnitClassification.Biological && this.GetUnit(interaction.SourceUnit).UnitClassification == UnitClassification.Biological) ||
                        (targetUnit.UnitClassification == UnitClassification.Mechanical && this.GetUnit(interaction.SourceUnit).UnitClassification == UnitClassification.Psionic) ||
                        (targetUnit.UnitClassification == UnitClassification.Mechanical && this.GetUnit(interaction.SourceUnit).UnitClassification == UnitClassification.Psionic)
                        )
                    {
                        targetUnit.AddSupplement(new InfestationSpores());
                    }
                                      
                    break;
                default:
                    base.ProcessSingleInteraction(interaction);
                    break;
            }
            
        }
    }
}
