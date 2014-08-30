using System;
using System.Collections.Generic;

public class Bank
{
    public static void Main()
    {
        // Initializing lists of accounts
        List<LoanAccount> loanAccounts = new List<LoanAccount>()
        {
            new LoanAccount(Customer.Company, 0, 5),
            new LoanAccount(Customer.Individual, 0, 5),
        };

        List<DepositAccount> depositAccounts = new List<DepositAccount>()
        {
            new DepositAccount(Customer.Company, -1000, 10),
            new DepositAccount(Customer.Individual, -1000, 10)
        };

        List<MortgageAccount> mortgageAccounts = new List<MortgageAccount>()
        {
            new MortgageAccount(Customer.Company, 0, 9),
            new MortgageAccount(Customer.Individual, 0, 9)
        };

        // Testing depositing and withdrawing money
        loanAccounts[0].DepositMoney(300);
        loanAccounts[1].DepositMoney(2000);

        depositAccounts[0].DepositMoney(500);
        depositAccounts[1].DepositMoney(1200);

        depositAccounts[1].WithdrawMoney(10);

        mortgageAccounts[0].DepositMoney(1000);
        mortgageAccounts[1].DepositMoney(1500);

        // Merging the lists
        List<Account> accounts = new List<Account>();
        accounts.AddRange(loanAccounts);
        accounts.AddRange(depositAccounts);
        accounts.AddRange(mortgageAccounts);

        // Printing on the console
        foreach (Account account in accounts)
        {
            Console.WriteLine("{0}({1})'s Interest: {2}\n", account.GetType().Name, account.Customer, account.CalulateInterest(24));
        }
    }
}