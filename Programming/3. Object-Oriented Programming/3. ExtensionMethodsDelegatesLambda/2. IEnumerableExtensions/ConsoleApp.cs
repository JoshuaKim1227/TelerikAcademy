using System;
using System.Collections.Generic;

public class ConsoleApp
{
    public static void Main()
    {
        // Initializing Test List
        List<int> testList = new List<int>() { 1, 2, 4, 5 };

        // Testing Sum Method
        int sumResult = testList.Sum<int>();
        Console.WriteLine("The sum is: {0}", sumResult);

        // Testing Product Method
        int productResult = testList.Product<int>();
        Console.WriteLine("The product is: {0}", productResult);

        // Testing Min Value Method
        int minValue = testList.Min<int>();
        Console.WriteLine("The min value is: {0}", minValue);

        // Testing Min Value Method
        int maxValue = testList.Max<int>();
        Console.WriteLine("The max value is: {0}", maxValue);

        // Testing Min Value Method
        decimal averageValue = testList.Average<int>();
        Console.WriteLine("The average value is: {0}", averageValue);
    }
}
