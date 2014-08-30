using System;

public class Worker : Human
{
    private double weekSalary;
    private double workHoursPerDay;

    public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.WeekSalary = weekSalary;
        this.WorkHoursPerDay = workHoursPerDay;
    }

    public double WeekSalary
    {
        get { return this.weekSalary; }
        set { this.weekSalary = value; }
    }

    public double WorkHoursPerDay
    {
        get { return this.workHoursPerDay; }
        set { this.workHoursPerDay = value; }
    }

    public double MoneyPerHour()
    {
        return (this.WeekSalary / 5) / this.WorkHoursPerDay;
    }

    public double MoneyPerHour(int weekSalary, int workHoursPerDay)
    {
        return (weekSalary / 5) / workHoursPerDay;
    }

    public override string ToString()
    {
        return string.Format("Name of student: {0} {1}\nMoney per Hour: {2}", this.FirstName, this.LastName, this.MoneyPerHour());
    }
}