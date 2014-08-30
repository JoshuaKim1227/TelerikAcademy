using System;

class QuadraticEquationSolver
{
    static void Main()
    {
        Console.WriteLine("a*x*x + b*x + c = 0.  Enter values for 'a', 'b' and 'c'");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}*x^2 + {1}*x + {2} = 0", a, b, c);

        if (a != 0)
        {
            int d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("There is no solution!");
            }
            if (d == 0)
            {
                Console.WriteLine("x = {0};", (-b) / (2 * a));
            }
            if (d > 0)
            {
                Console.WriteLine("x1 = {0};\nx2 = {1};", (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a,(-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a);
            }

        }
        else Console.WriteLine("Invalid input!");
    }
}