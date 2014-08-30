namespace DefiningClasses_II.UI
{
    using System;
    using DefiningClasses_II.Core;

    [Version(3, 55)]
    public class Program
    {
        public static void Main()
        {
            // [ 3D POINTS ]
            Console.WriteLine("--- 3D points tests ---");

            // Printing the static zero point
            Console.WriteLine("Zero point:\n{0}", Point3D.ZeroPoint);

            // Creating two instances of the Point3D class
            Point3D point1 = new Point3D();
            Point3D point2 = new Point3D();

            point1.X = 3;
            point1.Y = 4;
            point1.Z = -4;

            point2.X = 1;
            point2.Y = 6;
            point2.Z = 2;

            // Calculating the distance between the two points
            double dist = DistanceCalculator.Calculate(point1, point2);
            Console.WriteLine("\nThe distance is: {0}", dist);

            // Loading path of points from a file
            Path pathForLoading = new Path();
            pathForLoading.SequenceOfPoints = PathStorage.LoadPath();

            // Printing the loaded points
            Console.WriteLine("\nThe path of points from file is:");
            foreach (Point3D point in pathForLoading.SequenceOfPoints)
            {
                Console.WriteLine(point + "\n");
            }

            // Adding the two points to a Path
            Path pathForWriting = new Path();
            pathForWriting.SequenceOfPoints.Add(point1);
            pathForWriting.SequenceOfPoints.Add(point2);

            // Wrinting the path to a file
            PathStorage.SavePath(pathForWriting);

            // [ GENERIC LIST ]
            Console.WriteLine("--- Generic List tests ---");

            // Testing Add method
            GenericList<int> testList = new GenericList<int>(3);
            testList.Add(512);
            testList.Add(30);
            testList.Add(6);
            testList.Add(8);
            testList.Add(17);
            testList.Add(30);
            testList.Add(512);
            testList.Add(1);
            testList.Add(88);
            testList.Add(12);
            testList.Add(521);
            testList.Add(65);
            testList.Add(63);

            Console.WriteLine("Adding values");
            Console.WriteLine(testList);

            // Testing Remove method
            testList.RemoveAt(0);
            testList.RemoveAt(2);

            Console.WriteLine("Removing at position");
            Console.WriteLine(testList);

            // Testing Insert at position method
            Console.WriteLine("Inserting at position");
            testList.InsertAt(9999, 3);

            Console.WriteLine(testList);

            // Testing Search by value method
            int result = testList.FindByValue(12);

            Console.WriteLine("Search by value");
            Console.WriteLine("Your number is at Index [{0}]\n", result);

            // Testing to find min value
            Console.WriteLine("Finding min value");
            Console.WriteLine("Smallest value is at Index [{0}]\n", testList.Min<int>());

            // Testing to find max value
            Console.WriteLine("Finding max value");
            Console.WriteLine("Biggest value is at Index [{0}]\n", testList.Max<int>());

            // Testing Clear list method
            testList.Clear();

            // [ MATRIX ]
            Console.WriteLine("--- Matrix tests ---");

            Matrix<int> testMatrix1 = new Matrix<int>(5, 5);
            Matrix<int> testMatrix2 = new Matrix<int>(5, 5);
            Matrix<int> resultMatrix = new Matrix<int>(5, 5);
            Matrix<int> zeroMatrix = new Matrix<int>(5, 5);

            testMatrix1[3, 3] = 15;
            testMatrix1[3, 4] = 15;
            testMatrix1[4, 3] = 15;
            testMatrix1[4, 4] = 15;
            testMatrix1[1, 1] = 15;

            testMatrix2[3, 3] = 10;
            testMatrix2[3, 4] = 10;
            testMatrix2[4, 3] = 10;
            testMatrix2[4, 4] = 10;
            testMatrix2[1, 1] = 10;

            // Adding matrixes test
            resultMatrix = testMatrix1 + testMatrix2;

            Console.WriteLine("Adding matrixes");
            Console.WriteLine(testMatrix1);
            Console.WriteLine(testMatrix2);
            Console.WriteLine(resultMatrix);

            // Subtracting matrixes test
            resultMatrix = testMatrix1 - testMatrix2;

            Console.WriteLine("Substracting matrixes");
            Console.WriteLine(testMatrix1);
            Console.WriteLine(testMatrix2);
            Console.WriteLine(resultMatrix);

            // Multiplaying matrixes test
            resultMatrix = testMatrix1 * testMatrix2;

            Console.WriteLine("Multiplaying matrixes");
            Console.WriteLine(testMatrix1);
            Console.WriteLine(testMatrix2);
            Console.WriteLine(resultMatrix);

            // Check for non-zero elements
            Console.WriteLine("Check matrix for non-zero elements (true or false)");

            if (testMatrix1)
            {
                Console.WriteLine("The matrix has non-zero elements: True");
            }
            else
            {
                Console.WriteLine("The matrix has non-zero elements: False");
            }

            if (testMatrix2)
            {
                Console.WriteLine("The matrix has non-zero elements: True");
            }
            else
            {
                Console.WriteLine("The matrix has non-zero elements: False");
            }

            if (zeroMatrix)
            {
                Console.WriteLine("The matrix has non-zero elements: True");
            }
            else
            {
                Console.WriteLine("The matrix has non-zero elements: False");
            }

            // [ ATTRIBUTES ]
            Console.WriteLine("\n--- Attributes test ---");

            Type type = typeof(Program);
            object[] versionAttributes = type.GetCustomAttributes(false);

            foreach (VersionAttribute versionAttribute in versionAttributes)
            {
                Console.WriteLine("The version of the class 'Program' is {0}.{1}", versionAttribute.Major, versionAttribute.Minor);
            }
        }
    }
}