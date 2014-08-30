using System;

public class SquareRootPrinter
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter a positive integer: ");
            double number = GetNumber();
            Console.WriteLine("The number squared is: {0}", number);
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid Number");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid Number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid Number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }

    public static double GetNumber()
    {
        int userNum = int.Parse(Console.ReadLine());
        double squareRootNum = 0;

        if (userNum < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            squareRootNum = Math.Sqrt(userNum);
        }

        return squareRootNum;
    }
}