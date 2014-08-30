using System;
using System.Collections.Generic;
using System.Text;

public class ListOfWordsPrinter
{
    public static void Main()
    {
        // string words = "phone character visitor tool regular";
        Console.Write("Enter some words: ");
        string words = Console.ReadLine();

        string[] arrayOfWords = words.Split(' ');

        Array.Sort(arrayOfWords);

        StringBuilder builder = new StringBuilder();

        foreach (string word in arrayOfWords)
        {
            builder.Append(word + " ");
        }

        Console.WriteLine("\nThe words in alphabetical order are:");
        Console.WriteLine(builder.ToString());
    }
}