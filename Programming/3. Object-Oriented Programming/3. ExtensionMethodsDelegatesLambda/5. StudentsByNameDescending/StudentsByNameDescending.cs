using System;
using System.Linq;

public class StudentsByNameDescending
{
    public static void Main()
    {
        // Initializing an array of students
        var students = new[] 
        { 
            new { FirstName = "Pencho", LastName = "Georgiev" },
            new { FirstName = "Gancho", LastName = "Avramov" },
            new { FirstName = "Gogo", LastName = "Penchev" },
            new { FirstName = "Gogo", LastName = "Zalaliev" },
            new { FirstName = "Kircho", LastName = "Kirchev" }
        };

        // Sorting the students using lambda
        var result = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);

        // Printing the result
        Console.WriteLine("[Lambda] The students in descending order:");

        foreach (var student in result)
        {
            Console.WriteLine(student);
        }

        // Sorting the students using LINQ
        result =
            from student in students
            orderby student.FirstName descending, student.LastName descending
            select student;

        // Printing the result
        Console.WriteLine("\n[LINQ] The students in descending order:");

        foreach (var student in result)
        {
            Console.WriteLine(student);
        }
    }
}