using System;

public abstract class Account
{
    protected Account(Customer customer, int balance, int interestRate)
    {
        this.Customer = customer;
        this.Balance = balance;
        this.InterestRate = interestRate;
    }

    public Customer Customer { get; private set; }

    public int Balance { get; protected set; }

    public int InterestRate { get; private set; }

    public virtual int CalulateInterest(int months)
    {
        return this.InterestRate * months;
    }
}