using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class SentencesExtractor
{
    public static void Main()
    {
        string inputText;
        string word = "in";
        string[] sentenceArray;
        string[] resultSentences;

        inputText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        Console.WriteLine("The initial text:\n{0}", inputText);
        Console.WriteLine("\nThe target word is: {0}", word);
        sentenceArray = SeparateSentences(inputText);
        resultSentences = ChooseSentences(sentenceArray, word);

        Console.WriteLine("\nThe sentences, containing the target word are:");
        foreach (string sentence in resultSentences)
        {
            Console.WriteLine(sentence);
        }
    }

    public static string[] SeparateSentences(string text)
    {
        // Initializing data types
        string[] arrayOfSentences;
        string pattern = @"\.";

        // Splitting the string into sentences
        arrayOfSentences = Regex.Split(text, pattern);

        // Trimming the start of the sentences
        for (int index = 0; index < arrayOfSentences.Length; index++)
        {
            arrayOfSentences[index] = arrayOfSentences[index].TrimStart();
            arrayOfSentences[index] = arrayOfSentences[index] + ".";
        }

        return arrayOfSentences;
    }

    public static string[] ChooseSentences(string[] sentences, string targetWord)
    {
        // Initializing data types
        List<string> matchedSubstring = new List<string>();
        string pattern;

        // Using Regex to find sentenced with the target word
        pattern = @"\b" + targetWord + @"\b";

        // Writing matching sentences in a List of strings
        for (int index = 0; index < sentences.Length; index++)
        {
            if (Regex.IsMatch(sentences[index], pattern))
            {
                matchedSubstring.Add(sentences[index]);
            }
        }

        return matchedSubstring.ToArray();
    }
}