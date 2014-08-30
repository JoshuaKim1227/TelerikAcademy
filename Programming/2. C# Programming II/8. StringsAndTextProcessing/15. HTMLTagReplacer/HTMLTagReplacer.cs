using System;
using System.Text.RegularExpressions;

public class HTMLTagReplacer
{
    public static void Main()
    {
        string text = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        Console.WriteLine("The initial text is:\n{0}", text);
        string result = ReplaceTags(text);
        Console.WriteLine("\nThe result text is:\n{0}", result);
    }

    public static string ReplaceTags(string str)
    {
        string pattern;
        string replaced;

        pattern = "<a href=\"";
        replaced = Regex.Replace(str, pattern, "[URL=");

        pattern = "\">";
        replaced = Regex.Replace(replaced, pattern, "]");

        pattern = @"</a>";
        replaced = Regex.Replace(replaced, pattern, "[/URL]");

        return replaced;
    }
}