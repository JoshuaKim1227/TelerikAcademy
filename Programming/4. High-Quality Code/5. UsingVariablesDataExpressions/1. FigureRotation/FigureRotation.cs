using System;

public class FigureRotation
{
    static void Main()
    {
    }

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }
    }

    public static Size GetRotatedSize(Size size, double angleOfRotation)
    {
        double cosineOfAngle = Math.Cos(angleOfRotation);
        double sineOfAngle = Math.Cos(angleOfRotation);

        double absoluteOfCosineAngle = Math.Abs(cosineOfAngle);
        double absoluteOfSineAngle = Math.Abs(sineOfAngle);

        double widthSize = absoluteOfCosineAngle * size.Width + absoluteOfSineAngle * size.Height;
        double heightSize = absoluteOfSineAngle * size.Width + absoluteOfCosineAngle * size.Height;

        return new Size(widthSize, heightSize);
    }
}