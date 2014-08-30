using System;

public class ConsoleApp
{
    public static void Main()
    {
        Person person1 = new Person("Gancho", 21);
        Console.WriteLine(person1);

        Person person2 = new Person("Dobri");
        Console.WriteLine(person2);
    }
}