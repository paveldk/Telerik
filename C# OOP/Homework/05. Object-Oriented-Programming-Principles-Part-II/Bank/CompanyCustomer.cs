namespace Bank
{
    using System;

    class CompanyCustomer : Customer
    {
        public CompanyCustomer(string name, string address, string phone, string bulstat, string pic)
            : base(name, address, phone)
        {
            this.Bulstat = bulstat;
            this.PersonInCharge = pic;
        }

        public string Bulstat { get; set; }

        public string PersonInCharge { get; set; }
    }
}
