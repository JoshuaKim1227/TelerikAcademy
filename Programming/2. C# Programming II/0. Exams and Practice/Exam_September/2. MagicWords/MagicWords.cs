using System;
using System.Collections.Generic;
using System.Text;

public class MagicWords
{
    public static void Main()
    {
        List<string> words = GetInput();

        List<string> arrangedWords = ArrangeWords(words);

        PrintWords(arrangedWords);
    }

    public static List<string> GetInput()
    {
        int wordsCount = int.Parse(Console.ReadLine());
        List<string> words = new List<string>();

        for (int word = 0; word < wordsCount; word++)
        {
            words.Add(Console.ReadLine());
        }

        return words;
    }

    public static List<string> ArrangeWords(List<string> words)
    {
        string wordToMove;
        int wordLength = 0;
        int wordNewPosition = 0;

        for (int wordOldPosition = 0; wordOldPosition < words.Count; wordOldPosition++)
        {
            wordToMove = words[wordOldPosition];
            wordLength = words[wordOldPosition].Length;

            wordNewPosition = wordLength % (words.Count + 1);

            if (wordNewPosition == 0)
            {
                words.RemoveAt(wordOldPosition);
                words.Insert(0, wordToMove);
            }
            else if (wordNewPosition >= words.Count)
            {
                words.Add(wordToMove);
                words.RemoveAt(wordOldPosition);
            }
            else
            {
                if (wordOldPosition <= wordNewPosition)
                {
                    words.Insert(wordNewPosition, wordToMove);
                    words.RemoveAt(wordOldPosition);
                }
                else
                {
                    words.RemoveAt(wordOldPosition);
                    words.Insert(wordNewPosition, wordToMove);
                }
            }
        }

        return words;
    }

    public static void PrintWords(List<string> words)
    {
        StringBuilder builder = new StringBuilder();

        int letter = 0;
        int longestWordCount = FindLongestWordCount(words);

        while (letter < longestWordCount)
        {
            for (int word = 0; word < words.Count; word++)
            {
                string currentWord = words[word];

                if (letter < words[word].Length)
                {
                    builder.Append(currentWord[letter]);
                }

            }

            letter++;
        }

        Console.WriteLine(builder);
    }

    private static int FindLongestWordCount(List<string> words)
    {
        int longestWordCount = 0;

        for (int word = 0; word < words.Count; word++)
        {
            if (longestWordCount < words[word].Length)
            {
                longestWordCount = words[word].Length;
            }
        }

        return longestWordCount;
    }
}