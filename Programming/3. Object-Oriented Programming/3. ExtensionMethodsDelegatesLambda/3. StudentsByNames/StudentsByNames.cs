using System;
using System.Collections.Generic;
using System.Linq;

public class StudentsByNames
{
    public static void Main()
    {
        // Initializing an array of students
        var students = new[] 
        { 
            new { FirstName = "Pencho", LastName = "Georgiev" },
            new { FirstName = "Gancho", LastName = "Avramov" },
            new { FirstName = "Gogo", LastName = "Penchev" },
            new { FirstName = "Dancho", LastName = "Zalaliev" },
            new { FirstName = "Kircho", LastName = "Kirchev" }
        };

        // Finding the students matching the criteria
        var result =
            from student in students
            where student.FirstName.CompareTo(student.LastName) == -1
            select student;

        // Printing the result
        Console.WriteLine("The students whose first name is before the last name are:");

        foreach (var student in result)
        {
            Console.WriteLine(student);
        }
    }
}