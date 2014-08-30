using System;

public class BinSearchMethod
{
    public static void Main()
    {
        // Inizializing data types and getting user input
        Console.Write("Please enter value for N (length of the array): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter value for K (criteria): ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        int targetNum = 0;
        bool notFound = true;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter array number: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        // Printing the initial array
        Console.Write("\nThe numbers of the array are: ");
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        // Sorting the array in increasing order
        Array.Sort(array);

        // Searthing through the array for appropriate number
        // and printing the result
        for (int i = k; i >= 0; i--)
        {
            if (Array.BinarySearch(array, i) >= 0)
            {
                targetNum = array[Array.BinarySearch(array, i)];
                Console.WriteLine("The target number is: {0}", targetNum);
                notFound = false;
                break;
            }
        }

        if (notFound)
        {
            Console.WriteLine("No numbers match the criteria.");
        }
    }
}