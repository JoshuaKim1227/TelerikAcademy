using System;

class NumberMatrix
{
    static void Main()
    {
        int n;
        int numToWrite = 0;

        Console.WriteLine("Please enter a positive number: ");

        if (int.TryParse(Console.ReadLine(), out n) && (n > 0) && (n < 20))
        {
            for (int i = 1; i <= n; i++)
            {
                for (int count = 0; count < n; count++)
                {
                    numToWrite++;
                    Console.Write("{0,3}", numToWrite);
                }
                numToWrite = i;
                Console.WriteLine();
            }
        }
        else
	    {
            Console.WriteLine("Invalid input!");
	    }
    }
}

