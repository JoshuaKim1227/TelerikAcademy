using System;
using System.Diagnostics;

public class AritmeticPerformance
{
    static void Main()
    {
        AddMethods.AddInt();
        AddMethods.AddLong();
        AddMethods.AddFloat();
        AddMethods.AddDouble();
        AddMethods.AddDecimal();

        Console.WriteLine();

        SubstractMethods.SubstractInt();
        SubstractMethods.SubstractLong();
        SubstractMethods.SubstractFloat();
        SubstractMethods.SubstractDouble();
        SubstractMethods.SubstractDecimal();

        Console.WriteLine();

        IncrementMethods.IncrementInt();
        IncrementMethods.IncrementLong();
        IncrementMethods.IncrementFloat();
        IncrementMethods.IncrementDouble();
        IncrementMethods.IncrementDecimal();

        Console.WriteLine();

        MultiplyMethods.MultiplyInt();
        MultiplyMethods.MultiplyLong();
        MultiplyMethods.MultiplyFloat();
        MultiplyMethods.MultiplyDouble();
        MultiplyMethods.MultiplyDecimal();

        Console.WriteLine();

        DivideMethods.DivideInt();
        DivideMethods.DivideLong();
        DivideMethods.DivideFloat();
        DivideMethods.DivideDouble();
        DivideMethods.DivideDecimal();
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