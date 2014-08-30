using System;
using System.Diagnostics;

public class MathPerformance
{
    public static void Main()
    {
        RootMethods.SqareRootFloat();
        RootMethods.SqareRootDouble();
        RootMethods.SqareRootDecimal();

        Console.WriteLine();

        LogarithmMethods.LogarithmFloat();
        LogarithmMethods.LogarithmDouble();
        LogarithmMethods.LogarithmDecimal();

        Console.WriteLine();

        SinusMethods.SinusFloat();
        SinusMethods.SinusDouble();
        SinusMethods.SinusDecimal();
    }

    public static void DisplayExecutionTime(Action action)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        action();
        stopwatch.Stop();
        Console.WriteLine(stopwatch.Elapsed);
    }
}