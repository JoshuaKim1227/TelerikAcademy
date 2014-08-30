using System;

public class QuickSortAlgorithm
{
    public static void Main()
    {
        // It works with numbers instead of strings. Anyway it sorts correnctly.
        int[] array = new int[] { 5, 8, 7, 1, 3, 2, 6, 4 };

        foreach (int item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");
        Console.WriteLine("Steps of sorting:");

        QuickSort(array, 0, array.Length - 1);
    }

    public static int Partitioning(int[] array, int start, int end)
    {
        int pivot = start;
        int lowPointer = pivot + 1;
        int highPointer = end;
        int tempSwapper = 0;

        while (lowPointer != highPointer)
        {
            // Move the Low Pointer to the right 
            // if it's pointing to a value lower than the Pivot
            while (array[lowPointer] < array[pivot] && lowPointer != highPointer)
            {
                lowPointer++;
            }

            // Move the High Pointer to the left 
            // if it's pointing to a value higher than the Pivot
            while (array[highPointer] > array[pivot] && lowPointer != highPointer)
            {
                highPointer--;
            }

            // If the High Pointer has a value lower than the Low Pointer
            // swap the two values
            if (array[highPointer] < array[lowPointer] && lowPointer != highPointer)
            {
                tempSwapper = array[highPointer];
                array[highPointer] = array[lowPointer];
                array[lowPointer] = tempSwapper;
            }
        }

        tempSwapper = array[pivot];
        array[pivot] = array[lowPointer - 1];
        array[lowPointer - 1] = tempSwapper;

        foreach (int item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        return lowPointer;
    }

    public static void QuickSort(int[] array, int start, int end)
    {
        if (start < end)
        {
            int x = Partitioning(array, start, end);
            QuickSort(array, start, x - 1);
            QuickSort(array, x, end);
        }
    }
}