using System;
using System.Text;

public class ForbiddenWords
{
    public static void Main()
    {
        string inputText;
        string outputText;
        string[] forbiddenWords = new string[] { "PHP", "CLR", "Microsoft" };

        inputText = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";

        outputText = ReplaceForbiddenWords(inputText, forbiddenWords);

        Console.WriteLine(outputText);
    }

    public static string ReplaceForbiddenWords(string text, string[] words)
    {
        // Initializing data types
        string asterisks = string.Empty;

        // Itereting through the words in the array
        for (int index = 0; index < words.Length; index++)
        {
            // Finding and writing how many asterisks are needed to replace the current word
            for (int asteriskCount = 0; asteriskCount < words[index].Length; asteriskCount++)
            {
                asterisks = asterisks + "*";
            }

            // Replacing the forbidden words with asterisks
            text = text.Replace(words[index], asterisks);
            asterisks = string.Empty;
        }

        return text;
    }
}