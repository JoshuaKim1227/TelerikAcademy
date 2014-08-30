using System;

class FactorialNandK
{
    static void Main()
    {
        int n;
        int k;
        ulong factorialN = 1;
        ulong factorialK = 1;
        ulong factorialNandK = 1;
        ulong result = 0;

        Console.WriteLine("Enter two positive numbers (on separate lines): ");
        n = int.Parse(Console.ReadLine());
        k = int.Parse(Console.ReadLine());

        if ((n > 1) && (k > n))
        {
            for (int i = 1; i <= n; i++)
            {
                factorialN = factorialN * (ulong)i;
            }
            for (int i = 1; i <= k; i++)
            {
                factorialK = factorialK * (ulong)i;
            }
            for (int i = 1; i <= k - n; i++)
            {
                factorialNandK = factorialNandK * (ulong)i;
            }

            result = (factorialN * factorialK) / factorialNandK;
            Console.WriteLine("The result is {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

