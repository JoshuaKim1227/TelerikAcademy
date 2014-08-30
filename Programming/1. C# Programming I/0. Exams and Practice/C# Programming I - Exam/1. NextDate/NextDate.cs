using System;

class NextDate
{
    static void Main()
    {        
        // Initializing variables
        int day = 0;
        int month = 0;
        int year = 0;
        int lastDayOfMonth;
        bool isLeapYear = false;          
        int[] monthsLength = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Getting input
        day = int.Parse(Console.ReadLine());
        month = int.Parse(Console.ReadLine());
        year = int.Parse(Console.ReadLine());

        // Main logic
        isLeapYear = DateTime.IsLeapYear(year);
        if (isLeapYear)
        {
            monthsLength[1] = 29;
        }

        lastDayOfMonth = monthsLength[month - 1];
        if (day == lastDayOfMonth && month != 12)
        {
            day = 1;
            month++;
        }
        else if (day == lastDayOfMonth && month == 12)
        {
            day = 1;
            month = 1;
            year++;
        }
        else if (day != lastDayOfMonth)
        {
            day++;
        }

        // Printing the result
        Console.WriteLine("{0}.{1}.{2}\n", day, month, year);
    }
}

