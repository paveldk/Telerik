namespace Bank
{
    class MortgageAccount : Accounts, IDepositable
    {
        public MortgageAccount(Customer holder, string iban, decimal accountBalance, decimal accountInterestrate, int period)
            : base(holder, iban, accountBalance, accountInterestrate)
        {
            this.MortgagePeriod = period;
        }

        public int MortgagePeriod { get; protected set; }

        public override void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }
       
        public override decimal CalculateInterest()
        {
            if (this.MortgagePeriod <= 12 && this.AccountHolder is CompanyCustomer)
            {
                return this.InterestRate / 2 * this.MortgagePeriod;
            }
            else if (this.MortgagePeriod <= 6 && this.AccountHolder is IndividualCustomer)
            {
                return 0;
            }
            else
            {
                return this.InterestRate * this.MortgagePeriod;
            }
        }
    }
}
