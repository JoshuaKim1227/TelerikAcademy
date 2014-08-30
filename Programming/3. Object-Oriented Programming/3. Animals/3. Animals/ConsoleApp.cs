using System;
using System.Collections.Generic;

public class ConsoleApp
{
    static void Main()
    {
        // Produce sounds
        Kitten kitty = new Kitten("Pepa", 1);
        kitty.ProduceSound();

        Frog kyrmit = new Frog("Kyrmit", 3, Sex.Male);
        kyrmit.ProduceSound();

        Tomcat tom = new Tomcat("Tom", 8);
        tom.ProduceSound();

        Dog sharo = new Dog("Sharo", 15, Sex.Male);
        sharo.ProduceSound();

        Console.WriteLine();

        // Initializing list of Animals
        List<Animal> tomcats = new List<Animal>()
        {
            // Sex is always male
            new Tomcat("Tom", 8),
            new Tomcat("Bill", 9),
            new Tomcat("John", 7),
            new Tomcat("Gogo", 10),
            new Tomcat("Thomas", 11)
        };

        List<Animal> kittens = new List<Animal>()
        {
            // Sex is always female
            new Kitten("Kitty", 1),
            new Kitten("Kit", 2),
            new Kitten("Jitty", 1),
            new Kitten("Mitty", 1),
            new Kitten("Gitty", 2)
        };


        List<Animal> frogs = new List<Animal>()
        {
            new Frog("Kyrmit", 3, Sex.Male),
            new Frog("Maria", 2, Sex.Female),
            new Frog("Grigor", 3, Sex.Male),
            new Frog("Mara", 2, Sex.Female),
            new Frog("Mimi", 3, Sex.Female)
        };

        List<Animal> dogs = new List<Animal>()
        {
            new Dog("Sharo", 12, Sex.Male),
            new Dog("Billy", 14, Sex.Male),
            new Dog("Doggy", 11, Sex.Male),
            new Dog("Milka", 10, Sex.Female),
            new Dog("Mimi", 12, Sex.Female)
        };  

        // Calculating average age of animals
        double average = AverageAgeCalculator.CalculateAverageAge(tomcats);
        Console.WriteLine("Average Tomcat age is: {0}", average);

        average = AverageAgeCalculator.CalculateAverageAge(kittens);
        Console.WriteLine("Average Kitten age is: {0}", average);

        average = AverageAgeCalculator.CalculateAverageAge(frogs);
        Console.WriteLine("Average Frog age is: {0}", average);

        average = AverageAgeCalculator.CalculateAverageAge(dogs);
        Console.WriteLine("Average Dog age is: {0}", average);
    }
}