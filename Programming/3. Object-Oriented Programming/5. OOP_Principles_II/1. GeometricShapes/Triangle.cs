using System;

public class Triangle : Shape
{
    public Triangle(int height, int width)
    {
        this.Height = height;
        this.Width = width;
    }

    public override decimal CalculateSurface()
    {
        return this.Height * this.Width / 2;
    }
}