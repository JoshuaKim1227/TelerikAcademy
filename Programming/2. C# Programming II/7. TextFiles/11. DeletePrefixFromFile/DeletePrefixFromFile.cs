using System;
using System.IO;
using System.Text.RegularExpressions;

public class DeletePrefixFromFile
{
    public static void Main()
    {
        string fileContent = ReadFile("file.txt");
        string finalStr = DeleteSubstring(fileContent, "test");

        Console.WriteLine(finalStr);
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

    public static string DeleteSubstring(string strToWorkWith, string prefix)
    {
        string pattern = @"\btest\w*\b";
        string result;

        result = Regex.Replace(strToWorkWith, pattern, string.Empty);
        result = result.Replace("  ", " ");

        return result;
    }

    public static void WriteFile(string strToWrite, string fileName)
    {
        StreamWriter writer = new StreamWriter(fileName);

        using (writer)
        {
            writer.WriteLine(strToWrite);
        }

        Console.WriteLine("Result successfully writed to {0}.", fileName);
    }
}