using System;

public abstract class Human
{
    private string firstName;
    private string lastName;

    public string FirstName
    {
        get { return this.firstName; }
        set { this.firstName = value; }
    }

    public string LastName
    {
        get { return this.lastName; }
        set { this.lastName = value; }
    }

    public string ShowNamesOnly()
    {
        return string.Format("Name of subject: {0} {1}", this.FirstName, this.LastName);
    }
}