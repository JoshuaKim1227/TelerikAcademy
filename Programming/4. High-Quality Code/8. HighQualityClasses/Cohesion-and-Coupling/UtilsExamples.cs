using System;

namespace CohesionAndCoupling
{
    class UtilsExamples
    {
        static void Main()
        {
            FileExtensionGetter extensionGetter = new FileExtensionGetter();

            Console.WriteLine(extensionGetter.GetFileExtension("example"));
            Console.WriteLine(extensionGetter.GetFileExtension("example.pdf"));
            Console.WriteLine(extensionGetter.GetFileExtension("example.new.pdf"));

            Console.WriteLine(extensionGetter.GetFileNameWithoutExtension("example"));
            Console.WriteLine(extensionGetter.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(extensionGetter.GetFileNameWithoutExtension("example.new.pdf"));

            ShapeCalculator2D distanceCalculator2D = new ShapeCalculator2D();
            ShapeCalculator3D distanceCalculator3D = new ShapeCalculator3D();

            Console.WriteLine("Distance in the 2D space = {0:f2}", distanceCalculator2D.CalcDistance2D(1, 2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", distanceCalculator3D.CalcDistance3D(5, 2, 1, 3, 6, 4));

            DiagonalCalculator diagonalCalculator = new DiagonalCalculator(3, 4, 5);

            Console.WriteLine("Volume = {0:f2}", diagonalCalculator.CalcVolume());
            Console.WriteLine("Diagonal XYZ = {0:f2}", diagonalCalculator.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", diagonalCalculator.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", diagonalCalculator.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", diagonalCalculator.CalcDiagonalYZ());
        }
    }
}
