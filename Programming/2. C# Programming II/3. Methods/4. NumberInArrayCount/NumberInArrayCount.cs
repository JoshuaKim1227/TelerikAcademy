using System;

public class NumberInArrayCount
{
    public static int numberToSearch;
    public static int[] arrayOfNumbers;
    public static int arrayLength;
    public static int result;

    public static void Main()
    {
        GetUserInput();
        result = CountNumberInArray(arrayOfNumbers);
        PrintTheResult(result);
    }

    public static void GetUserInput()
    {
        Console.Write("Enter a number to search for: ");
        numberToSearch = int.Parse(Console.ReadLine());

        Console.Write("Enter a number for the length of the array: ");
        arrayLength = int.Parse(Console.ReadLine());
        arrayOfNumbers = new int[arrayLength];

        Console.WriteLine("Enter the numbers for the array (each number of a separate line): ");

        for (int i = 0; i < arrayLength; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
    }

    public static int CountNumberInArray(int[] array)
    {
        int counter = 0;

        for (int i = 0; i < arrayLength; i++)
        {
            if (array[i] == numberToSearch)
            {
                counter++;
            }
        }

        return counter;
    }

    public static void PrintTheResult(int numberToPrint)
    {
        Console.WriteLine("\nThe number you chose appears {0} times.", numberToPrint);
    }
}