using System;
using System.Diagnostics;

public static class SubstractMethods
{
    public static void SubstractInt()
    {
        Console.Write("Substract performance (int):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            int count = 10000000;
            for (int i = 0; i < 10000000; i++)
            {
                count--;
            }
        });
    }

    public static void SubstractLong()
    {
        Console.Write("Substract performance (long):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            long count = 10000000;
            for (long i = 0; i < 10000000; i++)
            {
                count--;
            }
        });
    }

    public static void SubstractFloat()
    {
        Console.Write("Substract performance (float):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            float count = 10000000;
            for (float i = 0; i < 10000000; i++)
            {
                count--;
            }
        });
    }

    public static void SubstractDouble()
    {
        Console.Write("Substract performance (double):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            double count = 10000000;
            for (double i = 0; i < 10000000; i++)
            {
                count--;
            }
        });
    }

    public static void SubstractDecimal()
    {
        Console.Write("Substract performance (decimal):\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            decimal count = 10000000;
            for (decimal i = 0; i < 10000000; i++)
            {
                count--;
            }
        });
    }
}