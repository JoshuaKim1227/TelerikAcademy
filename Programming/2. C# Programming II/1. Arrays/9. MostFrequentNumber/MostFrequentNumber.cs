using System;

public class MostFrequentNumber
{
    public static void Main()
    {
        // Inizializing variables
        int arrayLength = 0;
        string userInput;

        int mostFrequent = 0;
        int tempFrequent = 0;
        int counter = 0;
        int tempCounter = 0;

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

        // Searching for the most frequent digit
        for (int i = 0; i < numbersArray.Length; i++)
        {
            for (int j = 0; j < numbersArray.Length; j++)
            {
                if (numbersArray[i] == numbersArray[j])
                {
                    tempFrequent = numbersArray[i];
                    tempCounter++;
                }
            }

            if (counter < tempCounter)
            {
                counter = tempCounter;
                mostFrequent = tempFrequent;
            }

            tempCounter = 0;
        }

        Console.WriteLine("The most frequent number is {0} and it is repeated {1} times.", mostFrequent, counter);
    }
}