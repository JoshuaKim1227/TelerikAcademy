using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class ToUpperCaseConverter
{
    public static void Main()
    {
        string inputText;
        string result;

        Console.WriteLine("Initial text is:");
        inputText = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        Console.WriteLine(inputText);
        result = ToUpperInTags(inputText);

        Console.WriteLine("\nThe result is:\n{0}", result);
    }

    public static string ToUpperInTags(string text)
    {
        // Initializing data types
        List<string> matchedSubstring = new List<string>();
        string pattern;

        // Using Regex to find the text between tags
        pattern = @"(?<=<upcase>).*?(?=</upcase>)";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match match in matches)
        {
            matchedSubstring.Add(match.ToString());
        }

        // Setting the case for the target text to Upper
        for (int index = 0; index < matchedSubstring.Count; index++)
        {
            text = text.Replace(matchedSubstring[index], matchedSubstring[index].ToUpper());
        }

        // Removing the tags from the text
        text = Regex.Replace(text, @"<upcase>|</upcase>", string.Empty);

        return text;
    }
}