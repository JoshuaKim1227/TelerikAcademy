using System;
using System.Numerics;

class CatalanianNumbers
{
    static void Main()
    {
        int n;
        BigInteger result;
        BigInteger factorialN = 1;
        BigInteger factorialNx2 = 1;
        BigInteger factorialNplus1 = 1;

        Console.WriteLine("Enter a positive number: ");

        if (int.TryParse(Console.ReadLine(), out n) && (n >= 0))
        {
            for (int i = 1; i <= n; i++)
            {
                factorialN = factorialN * i;
            }
            for (int i = 1; i <= (n * 2); i++)
            {
                factorialNx2 = factorialNx2 * i;
            }
            for (int i = 1; i <= (n + 1); i++)
            {
                factorialNplus1 = factorialNplus1 * i;
            }
            result = factorialNx2 / (factorialNplus1 * factorialN);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}
