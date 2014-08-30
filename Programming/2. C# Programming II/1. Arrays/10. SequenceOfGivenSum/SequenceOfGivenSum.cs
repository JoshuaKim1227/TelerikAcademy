using System;

public class SequenceOfGivenSum
{
    public static void Main()
    {
        // Inizializing variables
        int arrayLength = 0;
        string userInput;
        int sum;

        int tempSum = 0;
        int startIndex = 0;
        int endIndex = 0;
        bool sumPresent = false;

        // int[] array = { 4, 3, 1, 4, 2, 5, 8 };

        // Getting user input
        Console.WriteLine("Enter the sum you want to find: ");
        sum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the length of the array: ");
        arrayLength = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the numbers for the array (on a single line with spaces): ");
        userInput = Console.ReadLine();

        // Converting to int array
        string[] stringArray = userInput.Split(' ');
        int[] numbersArray = new int[stringArray.Length];

        for (int i = 0; i < stringArray.Length; i++)
        {
            numbersArray[i] = int.Parse(stringArray[i]);
        }

        // Main logic
        for (int i = 0; i < numbersArray.Length; i++)
        {
            tempSum = numbersArray[i];
            for (int j = i + 1; j < numbersArray.Length - 1; j++)
            {
                tempSum += numbersArray[j];
                if (tempSum == sum)
                {
                    startIndex = i;
                    endIndex = j;
                    sumPresent = true;
                    break;
                }
            }

            tempSum = 0;
        }

        // Printing the result
        if (sumPresent)
        {
            Console.Write("The given sum ({0}) is present. Here is the sequence: ", sum);
            for (int index = startIndex; index <= endIndex; index++)
            {
                Console.Write(numbersArray[index] + " ");
            }

            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("The given sum is not present.");
        }
    }
}