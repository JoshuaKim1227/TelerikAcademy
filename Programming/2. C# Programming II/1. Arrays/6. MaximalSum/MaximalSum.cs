using System;

public class MaximalSum
{
    public static void Main()
    {
        // Initializing data types
        string userArrayStr;
        int arrayLength;
        int elementsToCalculate;
        int mover;
        int greatestSum = 0;

        // Getting user input
        Console.WriteLine("Please enter the length of the array: ");
        arrayLength = int.Parse(Console.ReadLine());
        Console.WriteLine("How many elements to calculate: ");
        elementsToCalculate = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter {0} numbers for the array (on a single line with spaces): ", arrayLength);
        userArrayStr = Console.ReadLine();

        // Converting to int array
        string[] stringArray = userArrayStr.Split(' ');
        int[] numbersArray = new int[arrayLength];

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

        // Finding the greatest sum
        for (int i = numbersArray.Length - 1; i >= numbersArray.Length - elementsToCalculate; i--)
        {
            greatestSum += numbersArray[i];
        }

        // Printing the result
        Console.WriteLine("The maximal sum of {0} elements is: {1}", elementsToCalculate, greatestSum);
        Console.WriteLine("-------------------------------------");
        for (int i = numbersArray.Length - 1; i >= numbersArray.Length - elementsToCalculate; i--)
        {
            Console.WriteLine(" " + numbersArray[i]); 
        }
    }
}