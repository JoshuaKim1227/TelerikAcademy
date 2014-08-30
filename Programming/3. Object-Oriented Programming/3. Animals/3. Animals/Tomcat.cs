using System;

public class Tomcat : Cat, ISound
{
    public Tomcat(string name, int age)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public Sex sex
    {
        get { return this.Sex; }
        private set { this.Sex = Sex.Male; }
    }

    public override void ProduceSound()
    {
        Console.WriteLine("Tomcat says: Miauuu, Miauuu!");
    }
}