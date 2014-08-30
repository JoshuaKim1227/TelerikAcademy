using System;

public abstract class Shape
{
    private int height;
    private int width;

    public int Height
    {
        get { return this.height; }
        protected set { this.height = value; }
    }

    public int Width
    {
        get { return this.width; }
        protected set { this.width = value; }
    }

    public abstract decimal CalculateSurface();
}