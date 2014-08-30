using System;

public static class RootMethods
{
    public static void SqareRootFloat()
    {
        Console.Write("Square root performance (int):\t\t");

        MathPerformance.DisplayExecutionTime(() =>
            {
                float number = 1;

                for (float i = 0; i < 1000000; i++)
                {
                    Math.Sqrt(number);
                }
            });
    }

    public static void SqareRootDouble()
    {
        Console.Write("Square root performance (double):\t");

        MathPerformance.DisplayExecutionTime(() =>
        {
            double number = 1;

            for (double i = 0; i < 1000000; i++)
            {
                Math.Sqrt(number);
            }
        });
    }

    public static void SqareRootDecimal()
    {
        Console.Write("Square root performance (decimal):\t");

        MathPerformance.DisplayExecutionTime(() =>
        {
            decimal number = 1;

            for (decimal i = 0; i < 1000000; i++)
            {
                Math.Sqrt((double)number);
            }
        });
    }
}