using System;
using System.Threading;

class NumbersPrinter
{
    static void Main()
    {
        int n;

        Console.WriteLine("Please enter a positive number: ");
        n = int.Parse(Console.ReadLine());

        if (n >= 1)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(40);     
            }
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

