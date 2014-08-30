using System;

public class LoanAccount : Account, IDepositable
{
    public LoanAccount(Customer customer, int balance, int interestRate)
        : base(customer, balance, interestRate)
    {
    }

    public void DepositMoney(int amount)
    {
        if (amount > 0)
        {
            this.Balance += amount;
        }
        else
        {
            throw new InvalidOperationException("Deposit operation failed. The amount of money to withdraw must be positive number.");
        }
    }

    public override int CalulateInterest(int months)
    {
        if (this.Customer == Customer.Individual)
        {
            if (months > 3)
            {
                return this.InterestRate * (months - 3);
            }
            else
            {
                return 0;
            }
        }
        else
        {
            if (months > 2)
            {
                return this.InterestRate * (months - 2);
            }
            else
            {
                return 0;
            }
        }
    }
}