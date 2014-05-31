namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;

    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted = false;
        private decimal initialHeight;

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.InitialHeight = height;
        }

        public bool IsConverted
        {
            get 
            {
                return this.isConverted;
            }

            protected set
            {
                this.isConverted = value;
            }
        }

        public decimal InitialHeight
        {
            get
            {
                return this.initialHeight;
            }
            protected set
            {
                this.initialHeight = value;
            }
        }

        public void Convert()
        {
            isConverted = !isConverted;
            if (isConverted)
            {
                this.Height = 0.10m;
            }
            else
            {
                this.Height = this.InitialHeight;
            }
        }

        public override string ToString()
        {
            string result = string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs, this.IsConverted ? "Converted" : "Normal");

            return result;
        }
    }
}
