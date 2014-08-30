using System;

class TrapezoidArea
{
    static void Main()
    {
        int sideA;
        int sideB;
        int height;
        int area;

        Console.WriteLine("Please enter Side A: ");
        sideA = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter Side B: ");
        sideB = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter side the Height: ");
        height = int.Parse(Console.ReadLine());

        area = (sideA + sideB) / 2;
        area = area * height;

        Console.WriteLine("The area of the Trapezoid is: {0}", area);
    }
}

