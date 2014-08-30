using System;

class FibonacciSequence
{
    static void Main()
    {
        int n = 0;
        long lastNum = 0;
        long newNum = 1;
        long result;
        long sum = 1;

        do
	    {
	        Console.WriteLine("Please enter a positive number: ");
            n = int.Parse(Console.ReadLine());
	    } 
        while (n <=0);

        for (int i = 0; i < n; i++)
        {
            result = lastNum + newNum;
            lastNum = newNum;
            newNum = result;
            sum = sum + result;
            Console.WriteLine("{0}", result);
        }
        Console.WriteLine("The sum of the Fibonacci nubmers is: {0}", sum);
    }
}

