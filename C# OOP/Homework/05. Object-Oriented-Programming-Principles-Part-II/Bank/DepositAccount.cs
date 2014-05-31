namespace Bank
{
    using System;

    // only this type of account is IDrawable and only here the Draw is working
    public class DepositAccount : Accounts, IDepositable, IDrawable
    {
        public DepositAccount(Customer holder, string iban, decimal accountBalance, decimal accountInterestrate, int period)
            : base(holder, iban, accountBalance, accountInterestrate)
        {
            this.DepositPeriod = period;
        }

        public int DepositPeriod { get; protected set; }

        public override void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }

        public override void Draw(decimal ammount)
        {
            if (this.Balance > ammount)
            {
                this.Balance -= ammount;
            }
            else
            {
                throw new Exception("Not enough cash in the balance, you can draw maximum " + this.Balance + " leva");
            }
        }

        public override decimal CalculateInterest()
        {
            if (this.Balance < 0 && this.Balance <= 1000)
            {
                return 0;
            }
            else
            {
                return this.DepositPeriod * this.InterestRate;
            }
        }
    }
}
