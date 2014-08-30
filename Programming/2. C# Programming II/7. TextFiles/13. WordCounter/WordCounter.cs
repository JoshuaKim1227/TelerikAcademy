using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class WordCounter
{
    public static void Main()
    {
        string wordsToSearchFor = string.Empty;
        string fileContent = string.Empty;
        string[] listOfWords;
        string[] result;

        try
        {
            wordsToSearchFor = ReadFile("list.txt");
            fileContent = ReadFile("test.txt");

            listOfWords = ConvertStringToList(wordsToSearchFor);

            result = CountListedWords(fileContent, listOfWords);

            WriteFile(result, "result.txt");
        }
        catch (UnauthorizedAccessException unauthAccEx)
        {
            Console.WriteLine(unauthAccEx.Message);
            Console.WriteLine("\nOperation failed!\n");
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("\nOperation failed!\n");
        }
        catch (ArgumentException argEx)
        {
            Console.WriteLine(argEx.Message);
            Console.WriteLine("\nOperation failed!\n");
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

    public static string[] ConvertStringToList(string str)
    {
        string[] srtList;

        srtList = str.Split('\n');

        for (int index = 0; index < srtList.Length; index++)
        {
            srtList[index] = srtList[index].Trim();
        }

        return srtList;
    }

    public static string[] CountListedWords(string content, string[] list)
    {
        // Initializing data types
        string pattern;
        string[] result;
        int matchCount;
        List<string> word = new List<string>();
        MatchCollection matches;

        // Finding matches in the text
        for (int index = 0; index < list.Length; index++)
        {
            pattern = @"\b" + list[index] + @"\b";
            matches = Regex.Matches(content, pattern, RegexOptions.IgnoreCase);

            // Counting the matches
            matchCount = matches.Count;

            // Adding leading zeroes to make the sorting easier
            if (matchCount < 10)
            {
                word.Add("00" + matchCount + " times: " + list[index]);
            }
            else if (matchCount < 100)
            {
                word.Add("0" + matchCount + " times: " + list[index]);
            }
            else
            {
                word.Add(matchCount + " times: " + list[index]);
            }
        }

        // Sort the list of words
        word.Sort();

        // Convert from list to array
        result = word.ToArray();

        return result;
    }

    public static void WriteFile(string[] strToWrite, string fileName)
    {
        StreamWriter writer = new StreamWriter(fileName);

        using (writer)
        {
            foreach (string line in strToWrite)
            {
                writer.WriteLine(line);
            }
        }
    }
}