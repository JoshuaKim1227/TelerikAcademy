using System;
using System.Threading;

public static class Timer
{
    // Delegate declaration
    public delegate void MethodToExecute();

    // Method to use the delegate
    public static void ExecuteMethod(int t, MethodToExecute method)
    {
        while (true)
        {
            Thread.Sleep(t * 1000);
            method();
        }
    }
}