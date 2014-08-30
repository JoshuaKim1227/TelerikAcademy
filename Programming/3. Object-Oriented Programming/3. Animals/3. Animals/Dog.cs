using System;

public class Dog : Animal, ISound
{
    private string sound;

    public Dog(string name, int age, Sex sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }

    public string Sound
    {
        get { return this.sound; }
        set { this.sound = value; }
    }

    public void ProduceSound()
    {
        Console.WriteLine("Dog says: Bau, Bau!");
    }
}