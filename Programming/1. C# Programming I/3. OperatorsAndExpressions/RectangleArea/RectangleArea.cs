using System;

class RectangleArea
{
    static void Main()
    {
        int width;
        int height;
        int area;

        Console.WriteLine("Please enter the WIDTH of the rectangle: ");
        width = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the HEIGHT of the rectangle: ");
        height = int.Parse(Console.ReadLine());

        area = width * height;

        Console.WriteLine("The AREA of the rectangle is: {0}", area);
    }
}

