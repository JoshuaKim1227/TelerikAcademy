using System;

public class LongestSequence
{
    public static void Main()
    {
        // Initializing data types
        string userInput;
        int lenthCounter = 1;
        int longestLen = 0;
        int longestLenElement = 0;

        // Getting user input
        Console.WriteLine("Please enter the numbers for the array (on a single line with spaces): ");
        userInput = Console.ReadLine();

        // Converting to int array
        string[] stringArray = userInput.Split(' ');
        int[] numbersArray = new int[stringArray.Length];

        for (int i = 0; i < stringArray.Length; i++)
        {
            numbersArray[i] = int.Parse(stringArray[i]);
        }

        for (int i = 0; i < numbersArray.Length - 1; i++)
        {
            if (numbersArray[i] == numbersArray[i + 1])
            {
                lenthCounter++; 
            }
            else
            {
                if (longestLen < lenthCounter)
                {
                    longestLen = lenthCounter;
                    longestLenElement = numbersArray[i];
                }

                lenthCounter = 1;
            }
        }

        Console.WriteLine(longestLen + " " + longestLenElement);
    }
}