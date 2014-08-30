using System;

public static class DivideMethods
{
    public static void DivideInt()
    {
        Console.Write("Divide performance (int):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            int count = 10000000;
            for (int i = 0; i < 10000000; i++)
            {
                count /= 3;
            }
        });
    }

    public static void DivideLong()
    {
        Console.Write("Divide performance (long):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            long count = 10000000;
            for (long i = 0; i < 10000000; i++)
            {
                count /= 3;
            }
        });
    }

    public static void DivideFloat()
    {
        Console.Write("Divide performance (float):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            float count = 10000000;
            for (float i = 0; i < 10000000; i++)
            {
                count /= 3;
            }
        });
    }

    public static void DivideDouble()
    {
        Console.Write("Divide performance (double):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            double count = 10000000;
            for (double i = 0; i < 10000000; i++)
            {
                count /= 3;
            }
        });
    }

    public static void DivideDecimal()
    {
        Console.Write("Divide performance (decimal):\t\t");
        AritmeticPerformance.DisplayExecutionTime(() =>
        {
            decimal count = 10000000;
            for (decimal i = 0; i < 10000000; i++)
            {
                count /= 3;
            }
        });
    }
}