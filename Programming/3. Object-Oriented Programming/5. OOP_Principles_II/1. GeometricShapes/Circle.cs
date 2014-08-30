using System;

public class Circle : Shape
{
    public Circle(int height, int width)
    {
        if (height == width)
        {
            this.Height = height;
            this.Width = width;
        }
        else
        {
            throw new ArgumentException("The height and width of the circle mush be equal.");
        }
    }

    public override decimal CalculateSurface()
    {
        decimal r = (decimal)this.Height / 2;

        return (decimal)Math.PI * (r * r);
    }
}