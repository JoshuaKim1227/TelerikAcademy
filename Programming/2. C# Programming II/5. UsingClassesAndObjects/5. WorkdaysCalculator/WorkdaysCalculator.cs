using System;

public class WorkdaysCalculator
{
    static DateTime endDay = new DateTime();
    static DateTime[] notWorkingDays;
    static int workdays;

    public static void Main()
    {
        endDay = GetEndDate();
        notWorkingDays = GetHolidays();
        workdays = CalculateWorkdays(endDay, notWorkingDays);

        Console.WriteLine("\nThere are {0} workdays between today and the date you choose.", workdays);
    }

    public static DateTime GetEndDate()
    {
        // Inizializing data types
        string userDate;
        int year, month, day;

        // Getting user input
        Console.Write("Please enter a date after today [dd, mm, yyyy]: ");
        userDate = Console.ReadLine();

        // Splitting the input to ints
        string[] parts = userDate.Split(',');
        day = int.Parse(parts[0]);
        month = int.Parse(parts[1]);
        year = int.Parse(parts[2]);

        // Setting the date
        DateTime userDateTime = new DateTime(year, month, day);
        
        return userDateTime;
    }

    public static DateTime[] GetHolidays()
    {
        // Inizializing data types
        string userDate;
        int holidaysCount = 0;
        int year, month, day;

        // Get user input
        Console.WriteLine("How many holidays there are: ");
        holidaysCount = int.Parse(Console.ReadLine());

        DateTime[] holidays = new DateTime[holidaysCount];

        Console.WriteLine("Enter a list of holidays [dd, mm, yyyy]\n");

        // Splitting to array of dates
        for (int i = 0; i < holidaysCount; i++)
        {
            Console.Write("\nEnter date: ");

            userDate = Console.ReadLine();

            string[] parts = userDate.Split(',');
            day = int.Parse(parts[0]);
            month = int.Parse(parts[1]);
            year = int.Parse(parts[2]);

            holidays[i] = new DateTime(year, month, day);
        }

        return holidays;
    }

    public static int CalculateWorkdays(DateTime toDate, DateTime[] holidays)
    {
        // Inizializing data types
        int days;
        int workdaysCounter = 0;

        DateTime currentDate = new DateTime();

        // Getting how many days there are between today
        // and the given date
        TimeSpan span = endDay.Subtract(DateTime.Today);
        days = (int)span.TotalDays;

        DayOfWeek weekDay = new DayOfWeek();

        // Counting the workdays, excluding holidays
        for (int i = 1; i < days; i++)
        {
            currentDate = DateTime.Today.AddDays(i);
            weekDay = currentDate.DayOfWeek;

            if (weekDay.Equals(DayOfWeek.Saturday) || weekDay.Equals(DayOfWeek.Sunday))
            {
                continue;
            }

            for (int j = 0; j < holidays.Length; j++)
            {
                if (currentDate == holidays[j])
                {
                    workdaysCounter--;
                    break;
                }
            }

            workdaysCounter++;
        }

        return workdaysCounter;
    }
}