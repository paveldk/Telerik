namespace FurnitureManufacturer.Engine.Factories
{
    using Interfaces;
    using Interfaces.Engine;
    using Models;
    using System;
    using System.Collections.Generic;

    public class CompanyFactory : ICompanyFactory
    {
        private IList<string> companies = new List<string>();

        public ICompany CreateCompany(string name, string registrationNumber)
        {          
            if (!companies.Contains(name)) 
            {
                var company = new Company(name, registrationNumber);
                companies.Add(name);
                return company;
            }
            else
	        {
                throw new Exception("Company with this name is already added");              
	        }        
        }
    }
}
