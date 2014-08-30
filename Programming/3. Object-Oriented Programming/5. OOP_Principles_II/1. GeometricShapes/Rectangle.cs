using System;

public class Rectangle : Shape
{
    public Rectangle(int height, int width)
    {
        this.Height = height;
        this.Width = width;
    }

    public override decimal CalculateSurface()
    {
        return this.Height * this.Width;
    }
}