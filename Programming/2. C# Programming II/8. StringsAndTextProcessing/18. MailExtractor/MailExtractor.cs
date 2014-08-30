using System;
using System.Text.RegularExpressions;

public class MailExtractor
{
    public static void Main()
    {
        string text = "Strings are collections of characters. The C# language gancho_q@abv.bg introduces the string type. This type allows manolcho.n@gmail.com us to manipulate character data through methods and properties.";
        Console.WriteLine("The initial text is:\n{0}", text);

        string pattern = @"\b(\w|\.)*\.?@\w*\.\w*\b";
        var matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        Console.WriteLine("\nThe extracted E-mails are:");
        foreach (var mail in matches)
        {
            Console.WriteLine(mail);
        }
    }
}