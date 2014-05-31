/* A bank holds different types of accounts for its customers: deposit accounts, 
 * loan accounts and mortgage accounts. Customers could be individuals or companies.
 * All accounts have customer, balance and interest rate (monthly based). Deposit accounts 
 * are allowed to deposit and with draw money. Loan and mortgage accounts can only deposit
 * money.
 * All accounts can calculate their interest amount for a given period (in months). 
 * In the common case its is calculated as follows: number_of_months * interest_rate.
 * Loan accounts have no interest for the first 3 months if are held by individuals and 
 * for the first 2 months if are held by a company. 
 * Deposit accounts have no interest if their balance is positive and less than 1000.
 * Mortgage accounts have ½ interest for the first 12 months for companies and no interest 
 * for the first 6 months for individuals.
 * Your task is to write a program to model the bank system by classes and interfaces. 
 * You should identify the classes, interfaces, base classes and abstract actions and 
 * implement the calculation of the interest functionality through overridden methods.
 * */
namespace Bank
{
    using System;
    using System.Collections.Generic;

    class MainClass
    {
        static void Main()
        {
            // first to create list and add some customer, one individual and one company
            List<Customer> customers = new List<Customer>();

            customers.Add(new IndividualCustomer("Ivan Draganov Petrov", "Sofia, Mladost 3", "02/1234567", new DateTime(1981, 10, 12)));
            customers.Add(new CompanyCustomer("Absolut Inc", "Sofia, Druzhba 2", "02/765432", "10000234", "Ivan Draganov Petrov"));

            // then we gonna create 3 accounts, for each different type, Deposit for individual, loan and mortgage for company
            List<Accounts> accounts = new List<Accounts>();

            accounts.Add(new DepositAccount(customers[0], "BGPI11111", 2000m, 3.7m, 12));
            accounts.Add(new LoanAccounts(customers[1], "BGPI22222", 1000m, 7.86m, 1));
            accounts.Add(new MortgageAccount(customers[1], "BGPI22222", 1500m, 6.76m, 12));

            // we gonna print the start balance and try to Draw money, we can only draw from first account(deposit one)
            foreach (var account in accounts)
            {
                Console.WriteLine("Account: {0}, Balance {1}", account.Iban, account.Balance);                
                if (account is IDrawable)
                {
                    Console.WriteLine("From that(up) account I can draw money, let me get 100");
                    account.Draw(100);
                }
            }

            // and we can see that only first balance is 100 less
            Console.WriteLine("Now I have:");
            foreach (var account in accounts)
            {
                Console.WriteLine("Account: {0}, Balance {1}", account.Iban, account.Balance);
            }

            // and we can calculate the interest
            Console.WriteLine("My interests are:");
            foreach (var account in accounts)
            {
                Console.WriteLine(account.CalculateInterest());
            }           
        }
    }
}