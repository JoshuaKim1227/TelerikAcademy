using System;

public class Kitten : Cat, ISound
{
    public Kitten(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public Sex sex
    { 
        get { return this.Sex; }
        private set { this.Sex = Sex.Female; }
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Kitten says: Mqk, Mqk!");
    }
}