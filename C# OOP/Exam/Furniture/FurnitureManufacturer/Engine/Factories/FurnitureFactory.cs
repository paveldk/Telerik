namespace FurnitureManufacturer.Engine.Factories
{
    using System;
    using Interfaces;
    using Interfaces.Engine;
    using Models;
    using System.Collections.Generic;

    public class FurnitureFactory : IFurnitureFactory
    {
        private const string Wooden = "wooden";
        private const string Leather = "leather";
        private const string Plastic = "plastic";
        private const string InvalidMaterialName = "Invalid material name: {0}";

        private readonly IList<string> tables = new List<string>();
        private readonly IList<string> chairs = new List<string>();
        private readonly IList<string> adjustableChairs = new List<string>();
        private readonly IList<string> convertibleChairs = new List<string>();

        public ITable CreateTable(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
        {
            if (!tables.Contains(model))
            {
                var table = new Table(model, materialType, price, height, length, width);
                tables.Add(model);
                return table;
            }
            else
            {
                throw new Exception("Table with this model is already added");
            } 
        }

        public IChair CreateChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            if (!chairs.Contains(model))
            {
                var chair = new Chair(model, materialType, price, height, numberOfLegs);
                chairs.Add(model);
                return chair;
            }
            else
            {
                throw new Exception("Chair with this model is already added");
            } 
        }

        public IAdjustableChair CreateAdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            if (!adjustableChairs.Contains(model))
            {
                var adjustableChair = new AdjustableChair(model, materialType, price, height, numberOfLegs);
                adjustableChairs.Add(model);
                return adjustableChair;
            }
            else
            {
                throw new Exception("Adjustable Chair with this model is already added");
            } 
        }

        public IConvertibleChair CreateConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
        {
            if (!convertibleChairs.Contains(model))
            {
                var convertibleChair = new ConvertibleChair(model, materialType, price, height, numberOfLegs);
                convertibleChairs.Add(model);
                return convertibleChair;
            }
            else
            {
                throw new Exception("Convertible Chair with this model is already added");
            } 
        }

        private MaterialType GetMaterialType(string material)
        {
            switch (material)
            {
                case Wooden:
                    return MaterialType.Wooden;
                case Leather:
                    return MaterialType.Leather;
                case Plastic:
                    return MaterialType.Plastic;
                default:
                    throw new ArgumentException(string.Format(InvalidMaterialName, material));
            }
        }
    }
}
