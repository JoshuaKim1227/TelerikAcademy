using System;

class SumOfIntegers
{
    static void Main()
    {
        int a;
        int b;
        int c;

        Console.WriteLine("Please enter first number: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        b = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter third number: ");
        c = int.Parse(Console.ReadLine());

        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
    }
}

