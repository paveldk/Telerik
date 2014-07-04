namespace Bank
{
    public abstract class Accounts : IDepositable
    {
        public Accounts(Customer holder, string iban, decimal accountBalance, decimal accountInterestrate)
        {
            this.AccountHolder = holder;
            this.Iban = iban;
            this.Balance = accountBalance;
            this.InterestRate = accountInterestrate;
        }

        public Customer AccountHolder { get; protected set; }

        public string Iban { get; protected set; }

        public decimal Balance { get; protected set; }

        public decimal InterestRate { get; protected set; }

        public virtual decimal CalculateInterest()
        {
            return 0;
        }

        public virtual void Deposit(decimal ammount)
        {            
        }

        // although Accounts aren't IDrawable we must add this method so to be able to use account.Draw()
        public virtual void Draw(decimal ammount)
        {      
        }
    }
}
