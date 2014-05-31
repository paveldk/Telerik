namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;
    using System.Text.RegularExpressions;

    class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures = new List<IFurniture>();

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
        }

        public string Name
        {
            get 
            {
                return this.name;
            }

            protected set
            {
                if (value.Length < 5 || value == string.Empty || value == null)
                {
                    throw new Exception("Name must be at last 5 symbols");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        public string RegistrationNumber
        {
            get 
            {
                return this.registrationNumber; 
            }

            protected set
            {
                int errorCounter = Regex.Matches(value, @"[a-zA-Z]").Count;

                if (value.Length != 10)
                {
                    throw new Exception("Length of registration number must be exactly 10 digits");
                }
                else if (errorCounter > 0)
	            {
                    throw new Exception("Length of registration number must consist only digits");
	            }
                else
                {
                    this.registrationNumber = value;
                }
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        
            protected set
            {
                this.furnitures = value;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            var firstFound = furnitures.Where(x => x.Model.ToLower().Contains(model.ToLower())).ToList();


            if (firstFound.Count != 0)
            {
                return firstFound[0];
            }

            return null;
        }

        public string Catalog()
        {
            StringBuilder result = new StringBuilder();
            if (this.furnitures.Count > 1)
            {
                result.AppendLine(this.Name + " - " + this.RegistrationNumber + " - " + this.furnitures.Count + " furnitures");
                var orderedFurnitures = furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model).ToList();

                for (int i = 0; i < orderedFurnitures.Count; i++)
                {
                    if (i != orderedFurnitures.Count - 1)
                    {
                        result.AppendLine(orderedFurnitures[i].ToString());
                    }
                    else
                    {
                        result.Append(orderedFurnitures[i].ToString());
                            
                    }
                }

                return result.ToString();
            }
            else if (this.furnitures.Count == 1)
            {
                result.AppendLine(this.Name + " - " + this.RegistrationNumber + " - " + this.furnitures.Count + " furniture");
                var orderedFurnitures = furnitures.OrderBy(x => x.Price).ThenBy(x => x.Model).ToList();

                foreach (var furn in furnitures)
                {
                    result.Append(furn.ToString());
                }

                return result.ToString();
            }
            else
            {
                return this.Name + " - " + this.RegistrationNumber + " - no furnitures";
            }

        }

        public override string ToString()
        {
            string result = string.Format("{0} - {1} - {2} {3}",
                                    this.Name,
                                    this.RegistrationNumber,
                                    this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                                    this.Furnitures.Count != 1 ? "furnitures" : "furniture");
            return result;
        }
    }
}
