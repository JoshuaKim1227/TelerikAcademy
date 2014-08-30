using System;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;

public class ListedWordsRemover
{
    public static void Main()
    {
        string wordsToRemove = string.Empty;
        string fileContent = string.Empty;
        string[] listOfWords;
        string result;

        try
        {
            wordsToRemove = ReadFile("list.txt");
            fileContent = ReadFile("file.txt");

            listOfWords = ConvertStringToList(wordsToRemove);

            result = RemoveListedWords(fileContent, listOfWords);

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

    public static string RemoveListedWords(string content, string[] list)
    {
        string pattern;

        for (int index = 0; index < list.Length; index++)
        {
            pattern = @"\b" + list[index] + @"\b";
            content = Regex.Replace(content, pattern, string.Empty, RegexOptions.IgnoreCase);
            content = content.Replace("  ", " ");
        }

        return content;
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