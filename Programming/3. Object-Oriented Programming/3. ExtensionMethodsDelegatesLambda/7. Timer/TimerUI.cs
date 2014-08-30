using System;
using System.Linq;

public class TimerUI
{
    public static void Main()
    {
        // Initializing a new delegate
        Timer.MethodToExecute methodToExecute;

        // Assingning methods to the delegate
        methodToExecute = PrintMessage;
        methodToExecute += PrintAnotherMessage;

        Timer.ExecuteMethod(2, methodToExecute);
    }

    public static void PrintMessage()
    {
        Console.WriteLine("I'm a message.");
    }

    public static void PrintAnotherMessage()
    {
        Console.WriteLine("I'm another message.");
    }
}