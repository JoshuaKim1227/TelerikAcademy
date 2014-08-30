using System;
using System.Collections.Generic;
using System.Linq;

public class ConsoleApp
{
    public static void Main()
    {
        // PART I
        // Initializing students list
        List<Student> students = new List<Student>()
        {
            new Student("Georgi", "Georgiev", 5),
            new Student("Ivan", "Petrov", 4),
            new Student("Kiril", "Penchev", 6),
            new Student("Atanas", "Ivanov", 4),
            new Student("Grigor", "Manolov", 3),
            new Student("Pavel", "Kostov", 5),
            new Student("Marin", "Marivon", 6),
            new Student("Atanas", "Anastasov", 5),
        };

        // Sorting students using LINQ
        var studentsByGrade =
            from student in students
            orderby student.Grade ascending
            select student;

        // Printing the result
        Console.WriteLine("[LINQ] Students ascending order by grade:");
        foreach (var student in studentsByGrade)
        {
            Console.WriteLine(student);
        }

        // Sorting students using Lambda
        studentsByGrade = students.OrderBy(student => student.Grade);

        // Printing the result
        Console.WriteLine("\n[Lambda] Students ascending order by grade:");
        foreach (var item in studentsByGrade)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nPress any key to continue to part II.");
        Console.WriteLine("Waiting...");
        Console.ReadKey();
        Console.Clear();

        // PART II
        // Initializing workers list
        List<Worker> workers = new List<Worker>()
        {
            new Worker("Pancho", "Penchev", 100, 8),
            new Worker("Jordan", "Ivanov", 120, 8),
            new Worker("Marian", "Asenov", 200, 6),
            new Worker("Gancho", "Pantiev", 80, 6),
            new Worker("Galin", "Grigorov", 300, 8),
            new Worker("Marian", "Minchev", 250, 6),
            new Worker("Petko", "Petrov", 60, 6),
            new Worker("Daniel", "Denev", 140, 8),
        };

        // Sorting workers using LINQ
        var workersByMoney =
            from worker in workers
            orderby worker.MoneyPerHour() descending
            select worker;

        // Printing the result
        Console.WriteLine("[LINQ] Workers descending order by money:");
        foreach (var worker in workersByMoney)
        {
            Console.WriteLine(worker);
        }

        workersByMoney = workers.OrderByDescending(worker => worker.MoneyPerHour());
        Console.WriteLine("\n[Lambda] Workers descending order by money:");
        foreach (var worker in workersByMoney)
        {
            Console.WriteLine(worker);
        }

        Console.WriteLine("\nPress any key to continue to part III.");
        Console.WriteLine("Waiting...");
        Console.ReadKey();
        Console.Clear();

        // PART III
        // Merging lists
        List<Human> subjects = new List<Human>();

        subjects.AddRange(students);
        subjects.AddRange(workers);

        // Sorting the merged list by LINQ
        var allSortedByName =
            from subject in subjects
            orderby subject.FirstName, subject.LastName ascending
            select subject;

        // Printing the result
        Console.WriteLine("[LINQ] Subjects ascending order by First name and Last name:");
        foreach (var subject in allSortedByName)
        {
            Console.WriteLine(subject.ShowNamesOnly());
        }

        // Sorting the merged list by Lambda
        allSortedByName = subjects.OrderBy(subject => subject.FirstName).ThenBy(subject => subject.LastName);

        // Printing the result
        Console.WriteLine("\n[Lambda] Subjects ascending order by First name and Last name:");
        foreach (var subject in allSortedByName)
        {
            Console.WriteLine(subject.ShowNamesOnly());
        }
    }
}