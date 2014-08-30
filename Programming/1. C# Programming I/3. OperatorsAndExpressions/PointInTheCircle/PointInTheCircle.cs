using System;

class PointInTheCircle
{
    static void Main()
    {
        int xCircle = 0;
        int yCircle = 5;
        int xPoint;
        int yPoint;
        int r = 5;
        int result;

        Console.WriteLine("Please enter the X point: ");
        xPoint = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the Y point: ");
        yPoint = int.Parse(Console.ReadLine());

        result = ((xPoint - xCircle) * (xPoint - xCircle)) + ((yPoint - yCircle) * (yPoint - yCircle));
        if (result <= (r * r))
        {
            Console.WriteLine("The point is in the circle.");
        }
        else
        {
            Console.WriteLine("The point is NOT in the circle.");
        }
    }
}

