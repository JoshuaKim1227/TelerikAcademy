using System;

public class ConsoleApp
{
    public static void Main()
    {
        Student student1 = new Student(
            "Petyr", 
            "Ivanov", 
            "Petrov", 
            9007053425, 
            "Delio Voivoda 5", 
            0112867234, 
            "petyr@fake.com", 
            2, 
            Specialty.ComputerScience, 
            University.SofiaUniversity, 
            Faculty.ComputerScienceFaculty);

        Student student2 = new Student(
            "Gancho", 
            "Georgiev", 
            "Penchev", 
            8002035628, 
            "Asen Zlatarov 12", 
            0113864918, 
            "gancho@fake.com", 
            3, 
            Specialty.Informatics, 
            University.TyrnovoUniversity, 
            Faculty.ComputerScienceFaculty);

        // Testing Equals, ==, !=
        Console.WriteLine("student1 Equals student2 --> {0}", student1.Equals(student2));
        Console.WriteLine("student1 == student2     --> {0}", student1 == student2);
        Console.WriteLine("student1 != student2     --> {0}", student1 != student2);

        Console.WriteLine(student1);
        Console.WriteLine(student2);

        // Testing Cloning
        Student clonedStudent = student1.Clone();
        Console.Write("STUDENT1 CLONED:");
        Console.WriteLine(clonedStudent);

        // Testing CompareTo()
        Console.WriteLine("The result from CompareTo() is: {0}", student1.CompareTo(student2));
    }
}