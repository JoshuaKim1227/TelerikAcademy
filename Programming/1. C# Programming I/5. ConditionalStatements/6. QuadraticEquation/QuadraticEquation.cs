using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Please enter tree numbers (on a separate lines): ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double d = b * b - 4 * a * c;

        if (a == 0)
        {
            Console.WriteLine("There is only one real root:\n x1: {0}", -c / b);
        }
        else if (d > 0)
        {
            double xOne = (-b + Math.Sqrt(d)) / 2 * a;
            double xTwo = (-b - Math.Sqrt(d)) / 2 * a;
            Console.WriteLine("There are two real roots:\n x1: {0} and x2: {1}", xOne, xTwo);
        }
        else if (d == 0)
        {
            double xOne = -(b / 2 * a);
            Console.WriteLine("There is only one real root:\n x1: {0}", xOne);
        }
        else
        {
            Console.WriteLine("There are no real roots");
        }
    }
}