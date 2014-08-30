using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class WordsInSentenceExtractor
{
    public static void Main()
    {
        // Detects word with 3 or more letters

        // string text = "When you concat strings, you put them together into a larger string. When you append a string, you put it at the end of another string.";
        Console.Write("Enter text: ");
        string text = Console.ReadLine();

        string[] result = CountWords(text);

        foreach (string line in result)
        {
            Console.WriteLine(line);
        }
    }

    public static string[] CountWords(string str)
    {
        // Initializing data types
        string currentWord = string.Empty;
        List<string> wordsInfo = new List<string>();
        List<string> usedWords = new List<string>();
        string lineOfInfo;
        string[] words;
        bool notUsed;
        int counter = 1;

        // Extract words from the string
        words = ExtractWords(str);

        // Iterating through words
        for (int index = 0; index < words.Length; index++)
        {
            // Reset counter
            counter = 1;

            // Check if the current word is used
            notUsed = CheckIfUsed(usedWords.ToArray(), words[index]);

            // If current word is not used count and do stuff
            if (notUsed)
            {
                // Add current word to the list of used words
                usedWords.Add(words[index]);

                // Set current word
                currentWord = words[index];

                // Count the appearance of the word 
                for (int comparePlace = index + 1; comparePlace < words.Length; comparePlace++)
                {
                    if (currentWord == words[comparePlace])
                    {
                        counter++;
                    }
                }

                // Write time or times, depending on counter value
                if (counter == 1)
                {
                    lineOfInfo = string.Format(currentWord + " is found {0} time", counter);
                }
                else
                {
                    lineOfInfo = string.Format(currentWord + " is found {0} times", counter);
                }

                // Add each line of text to a list of strings
                wordsInfo.Add(lineOfInfo);
            }
        }

        return wordsInfo.ToArray();
    }

    public static string[] ExtractWords(string str)
    {
        string pattern = @"\b\w{3,}\b";

        MatchCollection matches = Regex.Matches(str, pattern);
        string[] words = new string[matches.Count];

        for (int index = 0; index < matches.Count; index++)
        {
            words[index] = matches[index].ToString();
        }

        return words;
    }

    public static bool CheckIfUsed(string[] usedWords, string currentWord)
    {
        bool notUsed = true;

        foreach (string word in usedWords)
        {
            if (currentWord == word)
            {
                notUsed = false;
                break;
            }
        }

        return notUsed;
    }
}