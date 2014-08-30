using System;
using System.Collections.Generic;

public class MaxValueInArrayPortion
{
    // Inizializing data types
    static Random rand = new Random();

    static int arrayLength;
    static int numToStart;
    static int result;

    static int[] array;
    static List<int> sortedList;

    static bool sort;
    static bool ascending;

    public static void Main()
    {
        GetUserInput();
        RandomFillArray(array, arrayLength);
        VisualizeNumbers(array);

        if (sort)
        {
            sortedList = SortArray(array);

            foreach (int number in sortedList)
            {
                Console.Write(number + " ");
            }
        }
        else
        {
            result = GetMaxElement(array, numToStart);
            Console.WriteLine(result);
        }
    }

    // User Inputs and Choices Starts Here
    public static void GetUserInput()
    {
        // Check if the user wants the numbers sorted or only wants the biggest of a portion
        if (UserChoice_Sort())
        {
            // If the user wants sorting, check if he/she wants it in Ascending or Descending order
            UserChoice_AscendingOrDescending();
            sort = true;
        }
        else
        {
            BiggestInPortion();
            sort = false;
        }
    }

    public static bool UserChoice_Sort()
    {
        // Ask the user what he/she wants
        Console.Write("Do you want to sort the array or just to see the biggest num in a portion of it?");
        Console.WriteLine("(Choose 1 or 2)");
        Console.WriteLine("1. Biggest num in portion");
        Console.WriteLine("2. Sort the numbers");

        // Check if he/she choose to sort or only to get biggest num
        int choice = int.Parse(Console.ReadLine());

        while (choice < 1 || choice > 2)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("Try again: ");
            choice = int.Parse(Console.ReadLine());
        }

        if (choice == 1)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static void UserChoice_AscendingOrDescending()
    {
        // Ask the next questions based on the choices he/she made
        Console.WriteLine("Do you want to sort in ascending or descending order?");
        Console.WriteLine("(Choose 1 or 2)");
        Console.WriteLine("1. Ascending order");
        Console.WriteLine("2. Descending order");

        int choice = int.Parse(Console.ReadLine());

        // Validate input
        while (choice < 1 || choice > 2)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("Try again: ");
            choice = int.Parse(Console.ReadLine());
        }

        if (choice == 1)
        {
            ascending = true;
        }
        else
        {
            ascending = false;
        }

        Console.WriteLine("Enter the length of the array: ");
        arrayLength = int.Parse(Console.ReadLine());
    }

    public static void BiggestInPortion()
    {
        Console.WriteLine("Enter the length of the array: ");
        arrayLength = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the place to start from: ");
        numToStart = int.Parse(Console.ReadLine());
    }
    // User Inputs and Choices Ends Here

    public static int[] RandomFillArray(int[] arrayToFill, int arrayLen)
    {
        array = new int[arrayLen];

        for (int i = arrayLen - 1; i >= 0; i--)
        {
            array[i] = rand.Next(1, 21);
        }

        return array;
    }

    public static void VisualizeNumbers(int[] arr)
    {
        foreach (int number in arr)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }

    public static int GetMaxElement(int[] array, int startingPlace)
    {
        int biggestNum = int.MinValue;

        // Find the biggest starting from the aproppriate position
        for (int index = startingPlace - 1; index < array.Length; index++)
        {
            if (biggestNum < array[index])
            {
                biggestNum = array[index];
            }
        }

        // If the starting place is the last number, return it
        if (startingPlace == array.Length)
        {
            biggestNum = array[array.Length - 1];
        }

        return biggestNum;
    }

    public static List<int> SortArray(int[] arrayForSorting)
    {
        // Inizializing data types
        List<int> sortedList = new List<int>();
        int[] unsortedArray = new int[array.Length];
        int element;

        // Get the biggest element and write it in a list
        for (int index = 0; index < arrayForSorting.Length; index++)
        {
            element = GetMaxElement(arrayForSorting, 1);
            sortedList.Add(element);

            // Set the used element to int.MinValue
            for (int j = 0; j < arrayForSorting.Length; j++)
            {
                if (arrayForSorting[j] == element)
                {
                    arrayForSorting[j] = int.MinValue;
                    break;
                }
            }
        }

        // If user wants the numbers in ascending order, reverse the list
        if (ascending)
        {
            sortedList.Reverse();
        }

        return sortedList;
    }
}