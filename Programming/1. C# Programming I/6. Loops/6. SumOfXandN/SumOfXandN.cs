using System;

class SumOfXandN
{
    static void Main()
    {
        int n;
        int x;
        double xOnSelf = 1;
        double factorialN = 1;
        double result = 1;

        Console.WriteLine("Enter two positive numbers (on separate lines): ");
        n = int.Parse(Console.ReadLine());
        x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            xOnSelf = xOnSelf * x;
            factorialN = factorialN * i;
            result = result + (factorialN / xOnSelf);
        }
        Console.WriteLine("The result is: {0}", result + 1);
    }
}