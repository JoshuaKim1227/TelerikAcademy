using System;
using System.IO;
using System.Text.RegularExpressions;

public class StartAndFinishReplacer
{
    public static void Main()
    {
        string strFromFile = ReadFile("file.txt");
        string result = ReplaceSubstring(strFromFile, "start", "finish");
        WriteToFile(result, "result.txt");
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

    public static string ReplaceSubstring(string strToWorkWith, string initialWord, string newWord)
    {
        string pattern = @"\b" + initialWord + @"\b";
        string result;

        result = Regex.Replace(strToWorkWith, pattern, newWord);

        return result;
    }

    public static void WriteToFile(string strToWrite, string fileName)
    {
        StreamWriter writer = new StreamWriter(fileName);

        using (writer)
        {
            writer.WriteLine(strToWrite);
        }

        Console.WriteLine("Result successfully writed to {0}.", fileName);
    }
}