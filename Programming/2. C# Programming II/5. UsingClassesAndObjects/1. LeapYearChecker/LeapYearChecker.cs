using System;

public class LeapYearChecker
{
    public static void Main()
    {
        int year;
        bool isLeap;

        year = GetUserInput();
        isLeap = IsLeapYear(year);

        if (isLeap)
        {
            Console.WriteLine("\n{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("\n{0} is not a leap year.", year);
        }
    }

    public static int GetUserInput()
    {
        Console.WriteLine("Enter a year: ");
        int userInput = int.Parse(Console.ReadLine());

        return userInput;
    }

    public static bool IsLeapYear(int year)
    {
        return DateTime.IsLeapYear(year);
    }
}