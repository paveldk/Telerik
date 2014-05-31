namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;


    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;

        public Table(string model, string materialType, decimal price, decimal height, decimal length, decimal width)
            : base(model, materialType, price, height)
        {
            this.Length = length;
            this.Width = width;
        }

        public decimal Length
        {
            get 
            {
                return this.length;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new Exception("Length must be bigger than 0");
                }
                else
                {
                    this.length = value;
                }
            }
        }

        public decimal Width
        {
            get
            {
                return this.width;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new Exception("Width must be bigger than 0");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public decimal Area
        {
            get 
            {
                return this.length * this.width;
            }
        }

        public override string ToString()
        {
            string result = string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.Length, this.Width, this.Area);

            return result;
        }
    }
}
