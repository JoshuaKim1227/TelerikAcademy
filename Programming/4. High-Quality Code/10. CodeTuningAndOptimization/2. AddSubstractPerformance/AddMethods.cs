using System;

public static class AddMethods
{
    public static void AddInt()
    {
        Console.Write("Add performance (int):\t\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            int count = 0;
            for (int i = 0; i < 10000000; i++)
            {
                count += 3;
            }
        });
    }

    public static void AddLong()
    {
        Console.Write("Add performance (long):\t\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            long count = 0;
            for (long i = 0; i < 10000000; i++)
            {
                count += 3;
            }
        });
    }

    public static void AddFloat()
    {
        Console.Write("Add performance (float):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            float count = 0;
            for (float i = 0; i < 10000000; i++)
            {
                count += 3;
            }
        });
    }

    public static void AddDouble()
    {
        Console.Write("Add performance (double):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            double count = 0;
            for (double i = 0; i < 10000000; i++)
            {
                count += 3;
            }
        });
    }

    public static void AddDecimal()
    {
        Console.Write("Add performance (decimal):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            decimal count = 0;
            for (decimal i = 0; i < 10000000; i++)
            {
                count += 3;
            }
        });
    }
}