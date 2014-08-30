using System;
using System.Globalization;
using System.Text.RegularExpressions;

public class DateExtractor
{
    public static void Main()
    {
        string text = "A regular expression describes 30.10.2012 a text-based transformation. The Regex type in the C# language 2.5.2013 uses regular expressions. Regex searches text. It replaces text.";
        string pattern = @"\d{1,2}\.\d{1,2}\.\d{1,4}";
        string format;

        Console.WriteLine("The initial text is:\n{0}", text);
        var matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);
        format = "d.M.yyyy";

        Console.WriteLine("\nThe extracted dates are:");
        foreach (var item in matches)
        {
            DateTime date = new DateTime();
            date = DateTime.ParseExact(item.ToString(), format, CultureInfo.InvariantCulture);

            Console.WriteLine("{0:yyyy-MM-dd}", date);
        }
    }
}