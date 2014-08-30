using System;

public static class LogarithmMethods
{
    public static void LogarithmFloat()
    {
        Console.Write("Logarithm performance (float):\t\t");

        MathPerformance.DisplayExecutionTime(() =>
        {
            float number = 1;

            for (float i = 0; i < 1000000; i++)
            {
                Math.Log(number);
            }
        });
    }

    public static void LogarithmDouble()
    {
        Console.Write("Logarithm performance (double):\t\t");

        MathPerformance.DisplayExecutionTime(() =>
        {
            double number = 1;

            for (double i = 0; i < 1000000; i++)
            {
                Math.Log(number);
            }
        });
    }

    public static void LogarithmDecimal()
    {
        Console.Write("Logarithm performance (decimal):\t");

        MathPerformance.DisplayExecutionTime(() =>
        {
            decimal number = 1;

            for (decimal i = 0; i < 1000000; i++)
            {
                Math.Log((double)number);
            }
        });
    }
}
