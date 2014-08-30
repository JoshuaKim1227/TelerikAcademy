using System;

public class BiggerThanNeighbors
{
    static int positionInArray;
    static int[] arrayOfNumbers;
    static int arrayLength;
    static bool isBigger;

    public static void Main()
    {
        GetUserInput();
        Console.WriteLine("\nThe array is:");
        VisualizeNumbers();
        if (IsComparingPossible(arrayOfNumbers, positionInArray))
        {
            isBigger = CheckIfBiggerThanNeighbors(arrayOfNumbers, positionInArray);
        }

        PrintTheResult(isBigger);
    }

    public static void GetUserInput()
    {
        Console.Write("Enter a number for the length of the array: ");
        arrayLength = int.Parse(Console.ReadLine());
        arrayOfNumbers = new int[arrayLength];

        Console.Write("Choose a position (index) in the array: ");
        positionInArray = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the numbers for the array (each number on a separate line): ");

        for (int i = 0; i < arrayLength; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
    }

    public static void VisualizeNumbers()
    {
        for (int i = 0; i < arrayLength; i++)
        {
            if (i == positionInArray)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }

            Console.Write(arrayOfNumbers[i] + " ");
            Console.ResetColor();
        }

        Console.WriteLine();
    }

    public static bool IsComparingPossible(int[] array, int positionOfNumber)
    {
        if (positionOfNumber > 0 && positionOfNumber < array.Length - 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool CheckIfBiggerThanNeighbors(int[] array, int positionOfNumber)
    {
        if (array[positionOfNumber] > array[positionOfNumber - 1] && array[positionOfNumber] > array[positionOfNumber + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static void PrintTheResult(bool result)
    {
        if (IsComparingPossible(arrayOfNumbers, positionInArray))
        {
            Console.WriteLine("\nYour number is bigger than it's neighbors: {0}", result);
        }
        else
        {
            Console.WriteLine("\nIt's impossible to make a comparison.");
        }
    }
}