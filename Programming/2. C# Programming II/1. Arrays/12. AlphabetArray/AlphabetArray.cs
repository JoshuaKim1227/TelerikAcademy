using System;

public class AlphabetArray
{
    public static void Main()
    {
        // Inizializing variables
        int A = 65;
        string userWord;
        char[] alphabet = new char[26];

        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = Convert.ToChar(A + i);
        }

        // Getting input from the user
        Console.WriteLine("Please enter a word (in latin capital letters):");
        userWord = Console.ReadLine();
        Console.WriteLine("\nThe indexes of the letters are:");

        // Binary Search Algorithm
        for (int i = 0; i < userWord.Length; i++)
        {
            int start = 0;
            int middle = 0;
            int end = alphabet.Length - 1;

            while (alphabet[middle] != userWord[i])
            {
                middle = (start + end) / 2;
                if (alphabet[middle] > userWord[i])
                {
                    end = middle - 1;
                }
                else if (alphabet[middle] < userWord[i])
                {
                    start = middle + 1;
                }
            }

            Console.WriteLine(middle);
        }
    }
}