using System;
using System.Linq;

public class StudentsByAge
{
    public static void Main()
    {
        // Initializing an array of students
        var students = new[]
        {
            new { FirstName = "Georgi", SecondName = "Pavlov", Age = 18 },
            new { FirstName = "Mirko", SecondName = "Gogov", Age = 21 },
            new { FirstName = "Mincho", SecondName = "Minchev", Age = 29 },
            new { FirstName = "Kalcho", SecondName = "Ivanov", Age = 24 },
            new { FirstName = "Georgi", SecondName = "Georgiev", Age = 25 },
        };

        // Finding the students matching the criteria
        var result =
            from student in students
            where student.Age >= 18 && student.Age <= 24
            select student;

        // Printing the result
        Console.WriteLine("The students whose are is between 18 and 24 are:");

        foreach (var student in result)
        {
            Console.WriteLine(student);
        }
    }
}