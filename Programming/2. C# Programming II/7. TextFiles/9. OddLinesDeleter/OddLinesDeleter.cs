using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class OddLinesDeleter
{
    public static void Main()
    {
        string fileContent = ReadFile("file.txt");
        List<string> result = DeleteOddLines(fileContent);
        WriteFile(result, "file.txt");
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

    public static List<string> DeleteOddLines(string str)
    {
        // Initializing data types
        List<string> finalStr = new List<string>();
        string[] strLines = str.Split('\n');

        // Deleting odd lines
        for (int lineCounter = 0; lineCounter < strLines.Length; lineCounter++)
        {
            if (lineCounter % 2 != 0)
            {
                strLines[lineCounter] = string.Empty;
            }
        }

        // Removing blank lines
        for (int index = 0; index < strLines.Length; index++)
        {
            if (strLines[index] != string.Empty)
            {
                finalStr.Add(strLines[index]);
            }
        }

        return finalStr;
    }

    public static void WriteFile(List<string> strToWrite, string fileName)
    {
        StreamWriter writer = new StreamWriter(fileName);

        using (writer)
        {
            foreach (var line in strToWrite)
            {
                writer.WriteLine(line);
            }
        }

        Console.WriteLine("Operation successfull!");
    }
}