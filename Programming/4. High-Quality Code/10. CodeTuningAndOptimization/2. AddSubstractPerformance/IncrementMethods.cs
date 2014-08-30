using System;

public static class IncrementMethods
{
    public static void IncrementInt()
    {
        Console.Write("Increment performance (int):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            int count = 0;
            for (int i = 0; i < 10000000; i++)
            {
                count++;
            }
        });
    }

    public static void IncrementLong()
    {
        Console.Write("Increment performance (long):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            long count = 0;
            for (long i = 0; i < 10000000; i++)
            {
                count++;
            }
        });
    }

    public static void IncrementFloat()
    {
        Console.Write("Increment performance (float):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            float count = 0;
            for (float i = 0; i < 10000000; i++)
            {
                count++;
            }
        });
    }

    public static void IncrementDouble()
    {
        Console.Write("Increment performance (double):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            double count = 0;
            for (double i = 0; i < 10000000; i++)
            {
                count++;
            }
        });
    }

    public static void IncrementDecimal()
    {
        Console.Write("Increment performance (decimal):\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            decimal count = 0;
            for (decimal i = 0; i < 10000000; i++)
            {
                count++;
            }
        });
    }
}