using System;

public class SortByLength
{
    public static void Main()
    {
        // Inizializing the array
        string[] array = new string[5] { "******", "***", "*****", "*", "**" };

        // Printing the initial string
        Console.WriteLine("The initial array is:");
        foreach (string item in array)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        // Compare the strings using Lambda expression and sorting the array
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));

        // Printing the result
        Console.WriteLine("The sorted array is:");
        foreach (string item in array)
        {
            Console.WriteLine(item);
        }
    }
}