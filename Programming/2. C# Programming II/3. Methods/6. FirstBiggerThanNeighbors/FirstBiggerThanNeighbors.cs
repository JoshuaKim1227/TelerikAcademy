using System;

public class FirstBiggerThanNeighbors
{
    static int[] arrayOfNumbers;
    static int arrayLength;

    public static void Main()
    {
        GetUserInput();
        Console.WriteLine("The target number is at index: {0}", FirstBigger());
    }

    public static void GetUserInput()
    {
        Console.Write("Enter a number for the length of the array: ");
        arrayLength = int.Parse(Console.ReadLine());
        arrayOfNumbers = new int[arrayLength];

        Console.WriteLine("Enter the numbers for the array (each number on a separate line): ");

        for (int i = 0; i < arrayLength; i++)
        {
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }
    }

    public static int FirstBigger()
    {
        for (int i = 1; i < arrayOfNumbers.Length - 1; i++)
        {
            if (BiggerThanNeighbors.CheckIfBiggerThanNeighbors(arrayOfNumbers, i))
            {
                return i;
            }
        }

        return -1;
    }
}