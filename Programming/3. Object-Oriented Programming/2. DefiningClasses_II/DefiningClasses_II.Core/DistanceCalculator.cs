namespace DefiningClasses_II.Core
{
    using System;

    public static class DistanceCalculator
    {
        // Calculate distance method
        public static double Calculate(Point3D pointFirst, Point3D pointSecond)
        {
            int distX = pointSecond.X - pointFirst.X;
            int distY = pointSecond.Y - pointFirst.Y;
            int distZ = pointSecond.Z - pointFirst.Z;

            double distance = Math.Sqrt(Math.Pow(distX, 2) + Math.Pow(distY, 2) + Math.Pow(distZ, 2));

            return distance;
        }
    }
}
