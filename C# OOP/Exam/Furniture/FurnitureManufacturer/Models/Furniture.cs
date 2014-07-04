namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;

    public abstract class Furniture : IFurniture
    {
        private string model;
        private string material;
        private decimal price;
        private decimal height;
        

        private MaterialType type;

        public Furniture(string model, string materialType, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = materialType;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get 
            {
                return this.model;
            }

            protected set
            {
                if (value.Length < 3 || value == null || value == string.Empty)
                {
                    throw new Exception("Name of the model should be at least 3 symbols");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Material
        {
            get
            {
                return this.material;
            }

            protected set
            {
                switch (value)
                {
                    case "wooden" :
                        this.material = "Wooden";
                        break;
                    case "leather" :
                        this.material = "Leather";
                        break;
                    case "plastic":
                        this.material = "Plastic";
                        break;
                    default:
                        this.material = value;
                        break;
                }                
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price must be bigger than 0");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public decimal Height
        {
            get 
            {
                return this.height;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new Exception("Height must be bigger than 0");
                }
                else
                {               
                    this.height = value;                    
                }
            }
        }
    }
}
