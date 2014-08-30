using System;

public abstract class Animal
{
    private string name;
    private int age;
    private Sex sex;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public Sex Sex
    {
        get { return this.sex; }
        set { this.sex = value; }
    }
}