using System;

class CircleAreaAndPerimeter
{
    static void Main()
    {
        int radius;
        double perimeter;
        double area;

        Console.WriteLine("Please enter the radius af a circle: ");
        radius = int.Parse(Console.ReadLine());

        perimeter = (3.14 * 2) * radius;
        area = 3.14 * (radius * radius);

        Console.WriteLine("The perimeter of the circle is: {0}", perimeter);
        Console.WriteLine("The area of the circle is: {0}", area);
    }
}
