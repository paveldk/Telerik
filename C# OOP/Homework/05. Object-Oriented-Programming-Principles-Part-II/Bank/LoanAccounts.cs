namespace Bank
{
    public class LoanAccounts : Accounts, IDepositable
    {
        public LoanAccounts(Customer holder, string iban, decimal accountBalance, decimal accountInterestrate, int period)
            : base(holder, iban, accountBalance, accountInterestrate)
        {
            this.LoanPeriod = period;
        }

        public int LoanPeriod { get; protected set; }

        public override void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }
       
        public override decimal CalculateInterest()
        {
            if (this.LoanPeriod <= 3 && this.AccountHolder is IndividualCustomer)
            {
                return 0;
            }
            else if (this.LoanPeriod <= 2 && this.AccountHolder is CompanyCustomer)
            {
                return 0;
            }
            else
            {
                return this.LoanPeriod * this.InterestRate;
            }
        }
    }
}
