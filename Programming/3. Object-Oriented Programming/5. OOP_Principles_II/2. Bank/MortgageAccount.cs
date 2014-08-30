using System;

public class MortgageAccount : Account, IDepositable
{
    public MortgageAccount(Customer customer, int balance, int interestRate)
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
            if (months > 6)
            {
                return this.InterestRate * (months - 6);
            }
            else
            {
                return 0;
            }
        }
        else
        {
            if (months > 12)
            {
                return (12 * (this.InterestRate / 2)) + ((months - 12) * this.InterestRate);
            }
            else
            {
                return months * (this.InterestRate / 2);
            }
        }
    }
}