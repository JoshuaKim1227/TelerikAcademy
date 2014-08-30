using System;
using System.Collections.Generic;

public class ConsoleApp
{
    public static void Main()
    {
        // Testing with number
        int minValue = 1;
        int maxValue = 100;

        Console.WriteLine("Enter a number [1-100]: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 1 || number > 100)
        {
            throw new InvalidRangeException<int>(minValue, maxValue);
        }

        // Testing with date
        DateTime minDate = Convert.ToDateTime("01.01.1980");
        DateTime maxDate = Convert.ToDateTime("12.31.2013");

        Console.WriteLine("Enter a date in the range [1.1.1980 - 31.12.2013] in the format [mm.dd.yyyy]: ");
        DateTime date = Convert.ToDateTime(Console.ReadLine());

        if (date < minDate.Date || date > maxDate.Date)
        {
            throw new InvalidRangeException<DateTime>(minDate.Date, maxDate.Date);
        }
    }
}