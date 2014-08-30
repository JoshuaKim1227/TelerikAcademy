using System;
using System.Globalization;

public class DaysBetweenDatesCalculator
{
    public static void Main()
    {
        DateTime date1 = new DateTime();
        DateTime date2 = new DateTime();
        TimeSpan tSpan;
        string format = "dd.MM.yyyy";
        int yearsDistance;

        //Console.WriteLine("Enter the first date: ");
        //date1 = DateTime.Parse(Console.ReadLine());

        //Console.WriteLine("Enter the second date: ");
        //date2 = DateTime.Parse(Console.ReadLine());

        date1 = DateTime.ParseExact("27.02.2006", format, CultureInfo.InvariantCulture);
        date2 = DateTime.ParseExact("03.03.2004", format, CultureInfo.InvariantCulture);

        Console.WriteLine("First date is: {0}", date1);
        Console.WriteLine("Second date is: {0}", date2);

        if (date1.Year != date2.Year)
        {
            if (date1.Year < date2.Year)
            {
                yearsDistance = date2.Year - date1.Year;
                date1 = date1.AddYears(yearsDistance);
            }
            else
            {
                yearsDistance = date1.Year - date2.Year;
                date2 = date2.AddYears(yearsDistance);
            }
        }

        if (date1 < date2)
        {
            tSpan = date2 - date1;
        }
        else
        {
            tSpan = date1 - date2;
        }

        Console.WriteLine("\nDistance: {0} Days", tSpan.Days);
    }
}