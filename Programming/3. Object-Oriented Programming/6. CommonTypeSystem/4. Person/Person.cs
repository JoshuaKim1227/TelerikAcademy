using System;

public class Person
{
    private string name;
    private int? age;

    public Person(string name, int? age = null)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int? Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public override string ToString()
    {
        string str;

        str = string.Format("Person's Name: {0}\n", this.Name);

        if (this.Age != null)
        {
            str += string.Format("Person's Age: {0}\n", this.Age);
        }
        else
        {
            str += string.Format("Person's Age: {0}\n", "Unspecified");
        }

        return str;
    }
}