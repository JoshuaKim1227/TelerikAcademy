using System;

public class BinarySearchAlgorithm
{
    public static void Main()
    {
        int[] sortedArray = new int[10] { 1, 3, 6, 12, 18, 33, 40, 45, 51, 67 };
        int searchedValue = 67;
        int start = 0;
        int middle = 0;
        int end = sortedArray.Length - 1;

        Console.WriteLine("The searched number is: {0}", searchedValue);
        while (true)
        {
            middle = (start + end) / 2;
            if (sortedArray[middle] == searchedValue)
            {
                for (int i = 0; i < sortedArray.Length; i++)
                {
                    if (sortedArray[i] == sortedArray[middle])
                    {
                        Console.WriteLine("It has an index of: {0}", i);
                        return;
                    }
                }
            }
            else if (sortedArray[middle] > searchedValue)
            {
                end = middle - 1;
            }
            else if (sortedArray[middle] < searchedValue)
            {
                start = middle + 1;
            }
        }
    }
}