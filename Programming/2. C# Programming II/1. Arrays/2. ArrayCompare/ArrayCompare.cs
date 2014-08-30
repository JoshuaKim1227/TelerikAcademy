using System;

public class ArrayCompare
{
    public static void Main()
    {
        int arrayLength;
        bool isEqual = true;
        Console.WriteLine("Please enter the length of the arrays: ");

        if (int.TryParse(Console.ReadLine(), out arrayLength))
        {
            int[] firstArrayToCompare = new int[arrayLength];
            int[] secondArrayToCompare = new int[arrayLength];

            for (int index = 0; index < arrayLength; index++)
            {
                Console.WriteLine("Enter a number for the first array: ");           
                firstArrayToCompare[index] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            for (int index = 0; index < arrayLength; index++)
            {
                Console.WriteLine("Enter a number for the second array: ");
                secondArrayToCompare[index] = int.Parse(Console.ReadLine());
            }

            for (int index = 0; index < arrayLength; index++)
            {
                if (firstArrayToCompare[index] != secondArrayToCompare[index])
                {
                    isEqual = false;
                    Console.WriteLine("The arrays are not equal!");
                    break;
                }
            }

            if (isEqual)
            {
                Console.WriteLine("The arrays are equal!");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}