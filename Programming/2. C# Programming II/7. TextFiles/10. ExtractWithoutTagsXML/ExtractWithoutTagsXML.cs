using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class ExtractWithoutTagsXML
{
    public static void Main()
    {
        string fileContent = ReadFile("file.xml");
        List<string> final = ExtractText(fileContent);

        foreach (string line in final)
        {
            Console.WriteLine(line);
        }
    }

    public static string ReadFile(string fileName)
    {
        string outputStr;

        StreamReader reader = new StreamReader(fileName);

        using (reader)
        {
            outputStr = reader.ReadToEnd();
        }

        return outputStr;
    }

    public static List<string> ExtractText(string textToProccess)
    {
        // Initializing data types
        List<string> resultList = new List<string>();

        // Making a pattern for the RegEx
        string pattern = @"(?<=<(\w+)>).*(?=<\/\1>)";

        // Using the RegEx to extract the text between tags
        MatchCollection matches = Regex.Matches(textToProccess, pattern);

        // Writing the result to a List of strings
        foreach (Match match in matches)
        {
            foreach (Capture capture in match.Captures)
            {
                resultList.Add(capture.ToString());
            }
        }

        // Return the result :)
        return resultList;
    }
}