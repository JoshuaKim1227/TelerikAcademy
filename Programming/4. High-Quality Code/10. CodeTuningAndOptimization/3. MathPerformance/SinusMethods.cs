using System;

public static class SinusMethods
{
    public static void SinusFloat()
    {
        Console.Write("Sinus performance (float):\t\t");

        MathPerformance.DisplayExecutionTime(() =>
        {
            float number = 1;

            for (float i = 0; i < 1000000; i++)
            {
                Math.Sin(number);
            }
        });
    }

    public static void SinusDouble()
    {
        Console.Write("Sinus performance (double):\t\t");

        MathPerformance.DisplayExecutionTime(() =>
        {
            double number = 1;

            for (double i = 0; i < 1000000; i++)
            {
                Math.Sin(number);
            }
        });
    }

    public static void SinusDecimal()
    {
        Console.Write("Sinus performance (decimal):\t\t");

        MathPerformance.DisplayExecutionTime(() =>
        {
            decimal number = 1;

            for (decimal i = 0; i < 1000000; i++)
            {
                Math.Sin((double)number);
            }
        });
    }
}