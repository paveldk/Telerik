namespace Bank
{
    using System;

    class IndividualCustomer : Customer
    {
        public IndividualCustomer(string name, string address, string phone, DateTime birthDate)
            : base(name, address, phone)
        {
            this.BirthDate = birthDate;
        }

        public DateTime BirthDate { get; set; }
    }
}
