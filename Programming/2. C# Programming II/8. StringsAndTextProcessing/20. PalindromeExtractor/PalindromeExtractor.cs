using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class PalindromeExtractor
{
    public static void Main()
    {
        string text = "A regular expression describes ABBA a text-based transformation. The Regex type in the C# language lamal uses regular expressions. Regex exe searches text.";
        Console.WriteLine("The initial text is:\n{0}", text);
        
        string[] result = ExtractPalindromes(text);

        Console.WriteLine("\nThe extracted palindromes are:");
        foreach (string word in result)
        {
            Console.WriteLine(word);
        }
    }

    public static string[] ExtractPalindromes(string str)
    {
        // Initializing data types
        List<string> palindromeList = new List<string>();
        bool isPalindrome = true;

        // Extracting words to array
        string pattern = @"\b\w{3,}\b";
        var words = Regex.Matches(str, pattern);

        // Checking each word
        foreach (var item in words)
        {
            string word = item.ToString();

            for (int index = 0; index < word.Length; index++)
            {
                if (word[index] != word[word.Length - 1 - index])
                {
                    isPalindrome = false;
                    break;
                }
                else
                {
                    isPalindrome = true;
                }
            }

            // Wrinting palindrome words to a list
            if (isPalindrome)
            {
                palindromeList.Add(word);
            }
        }

        return palindromeList.ToArray();
    }
}