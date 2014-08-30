using System;

class IsPrime
{
    static void Main()
    {
        int n;
        int reminder;

        Console.WriteLine("Please enter a number: ");
        n = int.Parse(Console.ReadLine());

        if ((n <= 100) && (n > 0))
        {
            for (int devider = 2; devider <= n; devider++)
            {
                reminder = n % devider;
                if ((devider != n) && (reminder == 0))
                {
                    Console.WriteLine("The number is NOT prime.");
                    break;
                }
                Console.WriteLine("The number is prime.");
                break;
            }       
        }
        else
        {
            Console.WriteLine("Invalid Input");
        }
    }
}

