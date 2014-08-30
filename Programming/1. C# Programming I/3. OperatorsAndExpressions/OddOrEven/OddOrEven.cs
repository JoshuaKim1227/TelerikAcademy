using System;

class OddOrEven
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("ODD or EVEN Checker");
            Console.WriteLine("Please enter a number to check: ");
            int numToCheck = int.Parse(Console.ReadLine());
            int oddOrEven = numToCheck % 2;
            if (oddOrEven == 0)
            {
                Console.WriteLine("The number is EVEN\n");
            }
            else
            {
                Console.WriteLine("The number is ODD\n");
            }
        }
    }
}

