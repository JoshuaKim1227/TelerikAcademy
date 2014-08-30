using System;
using System.Collections.Generic;

public class FactorialCalculation
{
    static List<int> result = new List<int>();

    public static void Main()
    {
        Console.SetBufferSize(800, 302);
        Console.SetWindowSize(160, 50);

        for (int factorial = 1; factorial <= 100; factorial++)
        {
            result = CalculateFactorial(factorial);

            Console.WriteLine("Factorial of {0} is:", factorial);
            foreach (int digit in result)
            {
                Console.Write(digit);
            }

            Console.WriteLine("\n");
        }
    }

    public static List<int> MultiplyNumbers(int[] arrayOfDigits, int multiplier)
    {
        // Inizializing data types
        int product = 0;
        int digit;
        int count = 0;
        int[] numberToAdd;
        List<int> productList = new List<int>();
        List<int> finalResult = new List<int>();

        // Multiply every digit in the array, starting from the last
        for (int index = arrayOfDigits.Length - 1; index >= 0; index--)
        {
            product = arrayOfDigits[index] * multiplier;

            // Get every digit in the product and add it to a list of digits
            for (int placeInNum = product; placeInNum > 0; placeInNum = placeInNum / 10)
            {
                digit = product % 10;
                product = product / 10;
                productList.Add(digit);
            }

            // Reverse the list so the produst is corrent
            productList.Reverse();

            // Add appropriate number of zeroes at the end of the list
            for (int i = count; i > 0; i--)
            {
                productList.Add(0);
            }

            count++;

            // Convert the List to Array to be passed to AddNumbers()
            // and clear the product List so it can get new value
            numberToAdd = productList.ToArray();
            productList.Clear();

            // Calculating the sum using the AddNumbers() method
            finalResult = AddingArraysOfDigits.AddNumbers(finalResult.ToArray(), numberToAdd);
        }

        return finalResult;
    }

    public static List<int> CalculateFactorial(int factorialOf)
    {
        // Inizializing data types and adding the first number to the list
        List<int> factorialList = new List<int>();
        factorialList.Add(factorialOf);

        // Call the MultiplyNumbers() method with the appropriate parameters
        for (int numberToMultiply = factorialOf - 1; numberToMultiply > 0; numberToMultiply--)
        {
            factorialList = MultiplyNumbers(factorialList.ToArray(), numberToMultiply);
        }

        return factorialList;
    }
}