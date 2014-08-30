namespace DefiningClasses_II.Core
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public static class PathStorage
    {
        // Save to file method
        public static void SavePath(Path path)
        {
            using (StreamWriter fileWriter = new StreamWriter(@"../../../paths.txt"))
            {
                foreach (Point3D point in path.SequenceOfPoints)
                {
                    fileWriter.WriteLine(point.X + " " + point.Y + " " + point.Z);
                }
            }
        }

        // Write to file method
        public static List<Point3D> LoadPath()
        {
            Path loadPath = new Path();

            using (StreamReader fileReader = new StreamReader(@"../../../paths.txt"))
            {
                string line = fileReader.ReadLine();

                while (line != null)
                {
                    Point3D point = new Point3D();

                    string[] points = line.Split(' ');

                    point.X = int.Parse(points[0]);
                    point.Y = int.Parse(points[1]);
                    point.Z = int.Parse(points[2]);

                    loadPath.SequenceOfPoints.Add(point);

                    line = fileReader.ReadLine();
                }

                return loadPath.SequenceOfPoints;
            }
        }
    }
}
