namespace Bank
{
    public abstract class Customer
    {
        protected Customer(string name, string address, string phone)
        {
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public string Name { get; set; }

        public string Address { get; protected set; }

        public string Phone { get; protected set; }
    }
}
