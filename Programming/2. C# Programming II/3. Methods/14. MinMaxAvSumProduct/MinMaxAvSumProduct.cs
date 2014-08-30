using System;
using System.Collections.Generic;
using System.Numerics;

public class MinMaxAvSumProduct
{
    static int[] sequenceOfNums;

    public static void Main()
    {
        sequenceOfNums = GetSequenceOfInts();

        VisualizeNumbers();

        int min = CalculateMin(sequenceOfNums);
        int max = CalculateMax(sequenceOfNums);
        decimal average = CalculateAverage(sequenceOfNums);
        int sum = CalculateSum(sequenceOfNums);
        BigInteger product = CalculateProduct(sequenceOfNums);

        PrintResult(min, max, average, sum, product);
    }

    public static int[] GetSequenceOfInts()
    {
        // Inizializing data types
        int arrayLength;

        // Getting the length of the sequence and validating the input
        Console.Write("Enter a positive number (higher than 1) for the length of the sequence: ");

        while (!int.TryParse(Console.ReadLine(), out arrayLength) || arrayLength < 1)
        {
            Console.WriteLine("\nInvalid Input!");
            Console.Write("Enter a positive number: ");
        }

        // Inizializing the sequence (array) with the given length
        int[] arrayOfInts = new int[arrayLength];

        // Getting the numbers for the sequence and validating the input
        Console.WriteLine("\nYou should enter {0} integer numbers for the sequence", arrayLength);

        for (int numPlace = 1; numPlace <= arrayLength; numPlace++)
        {
            Console.Write("Enter a num for the {0}-th place: ", numPlace);

            while (!int.TryParse(Console.ReadLine(), out arrayOfInts[numPlace - 1]) || arrayOfInts[numPlace - 1] < 1)
            {
                Console.WriteLine("\nInvalid Input!");
                Console.Write("Enter a num for the {0}-th place: ", numPlace);
            }
        }

        return arrayOfInts;
    }

    public static void VisualizeNumbers()
    {
        Console.Clear();
        Console.WriteLine("The sequence is:");

        foreach (int number in sequenceOfNums)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine();
    }

    public static int CalculateMin(params int[] sequence)
    {
        int minValue = int.MaxValue;

        for (int index = 0; index < sequence.Length; index++)
        {
            if (minValue > sequence[index])
            {
                minValue = sequence[index];
            }
        }

        return minValue;
    }

    public static int CalculateMax(params int[] sequence)
    {
        int maxValue = int.MinValue;

        for (int index = 0; index < sequence.Length; index++)
        {
            if (maxValue < sequence[index])
            {
                maxValue = sequence[index];
            }
        }

        return maxValue;
    }

    public static decimal CalculateAverage(params int[] sequence)
    {
        decimal sum = 0;
        decimal average;

        for (int index = 0; index < sequence.Length; index++)
        {
            sum = sum + (decimal)sequence[index];
        }

        average = sum / sequence.Length;

        return average;
    }

    public static int CalculateSum(params int[] sequence)
    {
        int sum = 0;

        for (int index = 0; index < sequence.Length; index++)
        {
            sum = sum + sequence[index];
        }

        return sum;
    }

    public static long CalculateProduct(params int[] sequence)
    {
        long product = 1;

        for (int index = 0; index < sequence.Length; index++)
        {
            product = product * sequence[index];
        }

        return product;
    }

    public static void PrintResult(int minimal, int maximal, decimal avrg, int sum, BigInteger product)
    {
        Console.WriteLine("The minimal value is: {0}", minimal);

        Console.WriteLine("The maximal value is: {0}", maximal);

        Console.WriteLine("The average value is: {0}", avrg);

        Console.WriteLine("The sum is: {0}", sum);

        Console.WriteLine("The product is: {0}", product);
    }
}