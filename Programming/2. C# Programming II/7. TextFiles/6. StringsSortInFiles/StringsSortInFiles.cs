using System;
using System.IO;
using System.Text;

public class StringsSortInFiles
{
    public static void Main()
    {
        string strFromFile = ReadFile("file.txt");
        string[] strLines = SeparateLines(strFromFile);
        string[] sortedLines = SortStrings(strLines);
        WriteToFile(sortedLines, "result.txt");
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

    public static string[] SeparateLines(string strToSeparate)
    {
        strToSeparate = strToSeparate.Replace("\r", string.Empty);

        string[] linesOfStrings = strToSeparate.Split('\n');

        return linesOfStrings;
    }

    public static string[] SortStrings(string[] strToSort)
    {
        Array.Sort(strToSort, StringComparer.InvariantCulture);

        return strToSort;
    }

    public static void WriteToFile(string[] linesToWrite, string fileName)
    {
        StreamWriter writer = new StreamWriter(fileName);

        using (writer)
        {
            foreach (string line in linesToWrite)
            {
                writer.WriteLine(line);
            }
        }

        Console.WriteLine("Result successfully writed to {0}.", fileName);
    }
}