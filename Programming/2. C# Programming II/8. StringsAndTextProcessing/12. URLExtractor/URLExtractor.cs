using System;
using System.Text.RegularExpressions;

public class URLExtractor
{
    public static void Main()
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/20";
        Console.WriteLine("Initial URL is:\n{0}\n", url);

        string[] extractedParts = ExtractURL(url);

        Console.WriteLine("The result is:");
        Console.WriteLine("[protocol] = \"{0}\"", extractedParts[0]);
        Console.WriteLine("[server] = \"{0}\"", extractedParts[1]);
        Console.WriteLine("[resource] = \"{0}\"", extractedParts[2]);
    }

    public static string[] ExtractURL(string url)
    {
        string pattern;

        pattern = @"\w*(?=://)";
        Match protocol = Regex.Match(url, pattern, RegexOptions.IgnoreCase);

        pattern = @"(?<=://).*?(?=/)";
        Match server = Regex.Match(url, pattern, RegexOptions.IgnoreCase);

        pattern = @"(?<=(?<=://).*?(?=/)).*";
        Match resource = Regex.Match(url, pattern, RegexOptions.IgnoreCase);

        string[] parts = new string[3];

        parts[0] = protocol.ToString();
        parts[1] = server.ToString();
        parts[2] = resource.ToString();

        return parts;
    }
}