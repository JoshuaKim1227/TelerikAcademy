using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

public class HTMLTextExtractor
{
    public static void Main()
    {
        // Initializing data types
        string pattern;

        // Reading the input file
        string html = ReadFile();
        Console.WriteLine("The initial text is:\n{0}", html);

        // Extracting title text
        pattern = @"(?<=<title>).*(?=</title>)";
        string title = ExtractTitle(html, pattern);

        // Extracting body text
        pattern = @"<.*?>";
        string body = ExtractBodyText(html, pattern);

        // Printing the result
        Console.WriteLine("The result is:");
        Console.WriteLine(title);
        Console.WriteLine(body);
    }

    public static string ReadFile()
    {
        string fileOutput;
        StreamReader reader = new StreamReader("../../file.html");

        using (reader)
        {
            fileOutput = reader.ReadToEnd();
        }

        return fileOutput;
    }

    public static string ExtractTitle(string html, string pattern)
    {
        // Remove the tags
        string result = Regex.Match(html, pattern, RegexOptions.Singleline | RegexOptions.IgnoreCase).ToString();

        return result;
    }

    public static string ExtractBodyText(string html, string pattern)
    {
        // Initializing data types
        string bodyPart;
        string result;

        // Separate only the body part
        bodyPart = Regex.Match(html, "<body.*>.*</body>", RegexOptions.Singleline | RegexOptions.IgnoreCase).ToString();

        // Remove the tags
        result = Regex.Replace(bodyPart, pattern, " ", RegexOptions.Singleline | RegexOptions.IgnoreCase).ToString();

        return result;
    }
}