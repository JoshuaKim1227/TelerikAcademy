using System;
using System.Collections.Generic;

public class SequenceOfMaxSum
{
    public static void Main()
    {
        // Initializing variables
        int tempSum = 0;
        int startIndex = 0;
        int tempStart = 0;
        int endIndex = 0;
        int biggestSum = int.MinValue;
        int[] array = { -1, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        // Kadane's algorithm
        for (int index = 0; index < array.Length; index++)
        {
            tempSum += array[index];
            if (tempSum > biggestSum)
            {
                biggestSum = tempSum;
                startIndex = tempStart;
                endIndex = index;
            }

            if (tempSum < 0)
            {
                tempSum = 0;
                tempStart = index + 1;
            }
        }

        // Printing the result
        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write(array[i] + " ");
        }

        Console.WriteLine("\n" + biggestSum);
    }
}