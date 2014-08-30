using System;

class InCircleOutRectangle
{
    static void Main()
    {
        int xCircle = 1;
        int yCircle = 1;
        int rCircle = 3;

        int topRectangle = 1;
        int leftRectangle = -1;
        int widthRectangle = 6;
        int heightRectangle = 2;
          
        bool isInsideCircle = false;
        bool xOutsideRectangle = false;
        bool yOutsideRectangle = false;

        int xPoint;
        int yPoint;
        int formulaResult;

        Console.WriteLine("Please enter the X point: ");
        xPoint = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the Y point: ");
        yPoint = int.Parse(Console.ReadLine());

        formulaResult = ((xPoint - xCircle) * (xPoint - xCircle)) + ((yPoint - yCircle) * (yPoint - yCircle));
        isInsideCircle = formulaResult <= (rCircle * rCircle);

        xOutsideRectangle = (xPoint < leftRectangle) || (xPoint > (leftRectangle + widthRectangle));

        yOutsideRectangle = (yPoint > topRectangle) || (yPoint < (topRectangle - heightRectangle));

        if (isInsideCircle && (xOutsideRectangle || yOutsideRectangle))
        {
            Console.WriteLine("The Point is insite the Circle and outside the Rectangle.");
        }
        else
        {
            Console.WriteLine("The Point is NOT insite the Circle and outside the Rectangle.");
        }
    }
}

