using System;
using System.Collections.Generic;
using System.Text;

public class Dictionary
{
    public static void Main()
    {
        string[] linesInDict = new string[3];
        string[] wordsAndMeaning = new string[2];
        string userInput;

        linesInDict[0] = ".NET – platform for applications from Microsoft";
        linesInDict[1] = "CLR – managed execution environment for .NET";
        linesInDict[2] = "namespace – hierarchical organization of classes";

        Console.WriteLine("Write a word from the dictionary: ");
        userInput = Console.ReadLine();

        for (int index = 0; index < linesInDict.Length; index++)
        {
            wordsAndMeaning = linesInDict[index].Split('–');

            if (userInput == wordsAndMeaning[0].Trim())
            {
                Console.WriteLine(wordsAndMeaning[1].Trim());
            }
        }
    }
}