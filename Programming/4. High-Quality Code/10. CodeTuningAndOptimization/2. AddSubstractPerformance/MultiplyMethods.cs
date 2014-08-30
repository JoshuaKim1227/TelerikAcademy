using System;

public static class MultiplyMethods
{
    public static void MultiplyInt()
    {
        Console.Write("Multiply performance (int):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            int count = 1;
            for (int i = 0; i < 10000000; i++)
            {
                count *= 3;
            }
        });
    }

    public static void MultiplyLong()
    {
        Console.Write("Multiply performance (long):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            long count = 1;
            for (long i = 0; i < 10000000; i++)
            {
                count *= 3;
            }
        });
    }

    public static void MultiplyFloat()
    {
        Console.Write("Multiply performance (float):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            float count = 1;
            for (float i = 0; i < 10000000; i++)
            {
                count *= 3;
            }
        });
    }

    public static void MultiplyDouble()
    {
        Console.Write("Multiply performance (double):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            double count = 1;
            for (double i = 0; i < 10000000; i++)
            {
                count *= 3;
            }
        });
    }

    public static void MultiplyDecimal()
    {
        Console.Write("Multiply performance (decimal):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            decimal count = 0.01M;
            for (decimal i = 0; i < 10000000; i++)
            {
                count *= 0.02M;
            }
        });
    }
}