using System;

class FactorialNandK
{
    static void Main()
    {
        int n;
        int k;
        int factorialN = 1;
        int factorialK = 1;

        Console.WriteLine("Enter two positive numbers (on separate lines): ");
        n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());

        if ((n > k) && (k > 1))
        {
            for (int i = 1; i <= n; i++)
            {
                factorialN = factorialN * i;
            }
            for (int i = 1; i <= k; i++)
            {
                factorialK = factorialK * i;
            }
            Console.WriteLine("The result is: {0}", factorialN / factorialK);
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

