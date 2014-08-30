using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class WordsReverser
{
    public static void Main()
    {
        string text = "C# is not C++, not PHP and not Delphi!";
        Console.WriteLine("The initial text is:\n{0}", text);
        string reversedText = ReverseWords(text);

        Console.WriteLine("\nThe text with reversed words is:\n{0}", reversedText);
    }

    public static string ReverseWords(string str)
    {
        // Initializing data types
        List<string> words = new List<string>();
        List<string> punctuation = new List<string>();
        StringBuilder builder = new StringBuilder();
        string pattern;

        // Finding and writing the words to a string list
        pattern = @"\b.*?(\s|(?=,)|(?=!)|(?=\?))";
        MatchCollection matches = Regex.Matches(str, pattern);

        for (int index = 0; index < matches.Count; index++)
        {
            if (string.IsNullOrEmpty(matches[index].ToString()))
            {
                continue;
            }
            words.Add(matches[index].ToString().Trim());
        }

        // Reverses the list
        words.Reverse();

        // Finding and writing the spaces and punctuation to a string list
        pattern = @"(\s)|(,\s)|(\?)|(\!)|(\.)";
        MatchCollection punctuationMatches = Regex.Matches(str, pattern);

        for (int index = 0; index < punctuationMatches.Count; index++)
        {
            punctuation.Add(punctuationMatches[index].ToString());
        }

        // Using string builder to construct the reversed string
        for (int index = 0; index < words.Count; index++)
        {
            builder.Append(words[index]);
            builder.Append(punctuation[index]);
        }

        return builder.ToString();
    }
}