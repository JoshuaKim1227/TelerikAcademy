using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

public class DateTimeReader
{
    public static void Main()
    {
        string userInput;
        string format;
        DateTime userDate = new DateTime();
        DateTime newDate = new DateTime();

        // Console.Write("Enter a date [day.month.year hour:minute:second]: ");
        // userInput = Console.ReadLine();
        userInput = "03.5.2013 11:33:12";

        format = "d.M.yyyy hh:mm:ss";

        userDate = DateTime.ParseExact(userInput, format, CultureInfo.InvariantCulture);
        newDate = userDate.AddHours(6);
        newDate = newDate.AddMinutes(30);

        string test = string.Format("{0:d.M.yyyy hh:mm:ss}, {1}", newDate, newDate.ToString("dddd", new CultureInfo("bg-BG")));
        MessageBox.Show(test);

        Console.WriteLine("{0:d.M.yyyy hh:mm:ss}, {1}", newDate, newDate.ToString("dddd", new CultureInfo("bg-BG")));
    }
}