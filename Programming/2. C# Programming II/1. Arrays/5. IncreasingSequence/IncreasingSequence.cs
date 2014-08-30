using System;
using System.Collections.Generic;

public class IncreasingSequence
{
    public static void Main()
    {
        // Initializing data types
        string userInput;
        int lenthCounter = 1;
        int bestSeqLenth = 1;
        int endSeqNumber = 1;

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

        // Finding the longest increasing sequense
        for (int i = 0; i < numbersArray.Length - 1; i++)
        {
            if (numbersArray[i] == numbersArray[i + 1] - 1)
            {
                lenthCounter++;
            }
            else
            {
                lenthCounter = 1;
            }

            if (bestSeqLenth < lenthCounter)
            {
                bestSeqLenth = lenthCounter;
                endSeqNumber = numbersArray[i + 1];
            }
        }

        // Printing the result
        Console.WriteLine("The longest sequence is:");
        Console.WriteLine("\n{0} digits", bestSeqLenth);
        Console.WriteLine("---------");

        for (int i = endSeqNumber - bestSeqLenth + 1; i <= endSeqNumber; i++)
        {
            Console.WriteLine(i);
        }
    }
}