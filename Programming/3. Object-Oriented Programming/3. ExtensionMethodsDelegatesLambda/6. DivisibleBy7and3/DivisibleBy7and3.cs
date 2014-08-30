using System;
using System.Linq;

public class DivisibleBy7and3
{
    public static void Main()
    {
        // Initializing array of integers
        int[] numbers = new int[200];

        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = index;
        }

        // Finding the target items using lambda
        var result = numbers.Where(number => number % 7 == 0 && number % 3 == 0);

        // Printing the result
        Console.WriteLine("[Lambda] Numbers devisible by 7 and 3 are: ");
        foreach (var number in result)
        {
            Console.WriteLine(number);
        }

        // Finding the target items using LINQ
        result =
            from number in numbers
            where number % 7 == 0 && number % 3 == 0
            select number;

        // Printing the result
        Console.WriteLine("\n[LINQ] Numbers devisible by 7 and 3 are: ");
        foreach (var number in result)
        {
            Console.WriteLine(number);
        }
    }
}