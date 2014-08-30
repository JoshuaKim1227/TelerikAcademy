using System;

public class DayOfWeekPrint
{
    public static void Main()
    {
        DateTime now = new DateTime();
        now = DateTime.Now;
        DayOfWeek dayOfWeek = now.DayOfWeek;

        Console.WriteLine("Today is: {0}", dayOfWeek);
    }
}