using System;
using System.Text;

public class SubstringFinder
{
    public static void Main()
    {
        string inputText;
        string targetWord;
        int result;

        inputText = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        targetWord = "in";

        Console.WriteLine("The initial string is:");
        Console.WriteLine(inputText);
        Console.WriteLine("\nThe target word is: {0}", targetWord);

        result = FindSubstrings(inputText, targetWord);

        PrintResult(result);
    }

    public static string ReadInput()
    {
        string userInput;

        userInput = Console.ReadLine();

        return userInput;
    }

    public static int FindSubstrings(string text, string targetWord)
    {
        // Initializing data types
        int index = -1;
        int counter = -1;

        // Making strings upper case, so the search is case insensitive
        text = text.ToUpper();
        targetWord = targetWord.ToUpper();

        // Searching for the target word and counting
        do
        {
            counter++;
            index = text.IndexOf(targetWord, index + 1);
        } 
        while (index < text.Length - 1 && index >= 0);

        return counter;
    }

    public static void PrintResult(int result)
    {
        Console.WriteLine("\nThe result is: {0}", result);
    }
}