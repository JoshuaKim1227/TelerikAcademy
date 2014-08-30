using System;
using System.Text.RegularExpressions;

public class ConsecutiveLettersReplacer
{
    public static void Main()
    {
        // string text = "aaaaabbbbbcdddeeeedssaa";
        Console.Write("Enter consecutive letters: ");
        string text = Console.ReadLine();

        string pattern;

        Console.WriteLine("\nThe result is:");
        for (int placeInText = 0; placeInText < text.Length; placeInText++)
        {
            pattern = text[placeInText] + @"{2,}";
            text = Regex.Replace(text, pattern, text[placeInText].ToString());
        }

        Console.WriteLine(text);
    }
}