using System;

public class SurfaceOfATriangle
{
    public static void Main()
    {
        int userChoice = GetUserChoice();
        double finalResult = 0;

        if (userChoice == 1)
        {
            finalResult = CalculateBySideAndAltitude();
        }
        else if (userChoice == 2)
        {
            finalResult = CalculateByThreeSides();
        }
        else if (userChoice == 3)
        {
            finalResult = CalculateBTwoSidesAndAngle();
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }

        if (userChoice > 0 && userChoice < 4)
        {
            Console.WriteLine("\nThe area of the triangle is: {0}", finalResult);
        }
    }

    public static int GetUserChoice()
    {
        // Inizializing data types
        int input = 0;

        // Getting user choice
        Console.WriteLine("Select how the surface of the triangle will be calculated");
        Console.WriteLine("1. By side and an altitude to it");
        Console.WriteLine("2. By three sides");
        Console.WriteLine("3. By two sides and an angle between them");
        Console.Write("\n(Enter 1, 2 or 3): ");
        input = int.Parse(Console.ReadLine());

        return input;
    }

    public static double CalculateBySideAndAltitude()
    {
        // Getting user input
        Console.Write("\nEnter the side: ");
        double side = double.Parse(Console.ReadLine());
        Console.Write("\nEnter the altitude: ");
        double altitude = double.Parse(Console.ReadLine());

        // Calculating the formula
        double result = (side * altitude) / 2;

        return result;
    }

    public static double CalculateByThreeSides()
    {
        // Getting user input
        Console.Write("\nEnter the first side: ");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("\nEnter the second side: ");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("\nEnter the third side: ");
        double thirdSide = double.Parse(Console.ReadLine());

        // Finding the semiperimeter
        double semiPer = (firstSide + secondSide + thirdSide) / 2D;

        // Calculating the formula
        double result = Math.Sqrt(semiPer * (semiPer - firstSide) * (semiPer - secondSide) * (semiPer - thirdSide));

        return result;
    }

    public static double CalculateBTwoSidesAndAngle()
    {
        // Getting user input
        Console.Write("\nEnter the first side: ");
        double firstSide = double.Parse(Console.ReadLine());
        Console.Write("\nEnter the second side: ");
        double secondSide = double.Parse(Console.ReadLine());
        Console.Write("\nEnter the angle between sides: ");
        double angle = double.Parse(Console.ReadLine());

        // Calculating the formula
        double result = firstSide * secondSide * Math.Sin(Math.PI * angle / 180) / 2;

        return result;
    }
}