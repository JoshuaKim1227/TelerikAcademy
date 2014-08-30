using System;

public class SieveOfEratosthenesAlgorithm
{
    public static void Main()
    {
        // Inizializing variables
        int arrayLength = 10000000;
        int[] numbers = new int[arrayLength + 1];

        for (int i = 1; i <= arrayLength; i++)
        {
            numbers[i] = i;
        }

        // Sieve of Eratosthenes Algorithm
        for (int i = 2; (i * i) <= numbers.Length - 1; i++)
        {
            for (int j = i * i; j <= numbers.Length - 1; j = j + i)
            {
                numbers[j] = 0;
            }
        }

        // Printing prime numbers
        for (int i = 2; i < numbers.Length; i++)
        {
            if (numbers[i] != 0)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}