using System;

public class DepositAccount : Account, IDepositable, IWithdrawable
{
    public DepositAccount(Customer customer, int balance, int interestRate)
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

    public void WithdrawMoney(int amount)
    {
        if (amount > 0)
        {
            if (this.Balance >= amount)
            {
                this.Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Withdraw operation failed. Not enough money in account.");
            }
        }
        else
        {
            throw new ArgumentException("Withdraw operation failed. The amount of money to withdraw must be positive number.");
        }
    }

    public override int CalulateInterest(int months)
    {
        if (this.Balance < 0 || this.Balance > 1000)
        {
            return this.InterestRate * months;
        }
        else
        {
            return 0;
        }
    }
}