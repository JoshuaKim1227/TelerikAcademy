using System;

public class SelectionSortAlgorithm
{
    public static void Main()
    {
        // Initializing data types
        string userInput;
        int arrayLength;
        int mover;

        // Getting user input
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

        // Selection sort algorithm
        for (int i = 0; i < numbersArray.Length - 1; i++)
        {
            for (int j = i + 1; j < numbersArray.Length; j++)
            {
                if (numbersArray[i] > numbersArray[j])
                {
                    mover = numbersArray[i];
                    numbersArray[i] = numbersArray[j];
                    numbersArray[j] = mover;
                }
            }
        }

        Console.WriteLine("\nThe sorted numbers are:");
        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.WriteLine(numbersArray[i]);
        }
    }
}