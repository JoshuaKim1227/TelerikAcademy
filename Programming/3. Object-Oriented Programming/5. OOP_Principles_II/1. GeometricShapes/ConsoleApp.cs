using System;
using System.Collections.Generic;

public class ConsoleApp
{
    public static void Main()
    {
        // Initializing list of shapes
        List<Shape> shapes = new List<Shape>()
        {
            new Triangle(5, 7),
            new Rectangle(5, 10),
            new Circle(5, 5)
        };

        // Testing
        foreach (Shape shape in shapes)
        {
            Console.WriteLine("{0}'s area is: {1}", shape.GetType().Name, shape.CalculateSurface());
        }
    }
}