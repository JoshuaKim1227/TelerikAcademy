using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class LettersInSentenceExtractor
{
    public static void Main()
    {
        // string text = "When you concat strings, you put them together into a larger string. When you append a string, you put it at the end of another string.";
        string text = Console.ReadLine();

        string[] result = CountLetters(text);

        foreach (string line in result)
        {
            Console.WriteLine(line);
        }
    }

    public static string[] CountLetters(string str)
    {
        // Initializing data types
        int counter = 1;
        char currentLetter = '\0';
        string lineOfInfo;
        string pattern = @"\w";
        bool isLetter;
        bool notUsed;
        List<char> usedLetters = new List<char>();
        List<string> lettersInfo = new List<string>();

        // Checking letters
        for (int placeInString = 0; placeInString < str.Length; placeInString++)
        {
            // Reset counter
            counter = 1;
            
            // Using Regex to check if the symbol is a letter
            isLetter = Regex.IsMatch(str[placeInString].ToString(), pattern);

            // If it is a letter start counting
            if (isLetter)
            {
                // Check if current letter is already used
                notUsed = CheckIfUsed(usedLetters.ToArray(), str[placeInString]);

                // If it's not used, count and do stuff
                if (notUsed)
                {
                    // Write cuttent letter to the list of used letters
                    usedLetters.Add(str[placeInString]);

                    // Set current letter
                    currentLetter = str[placeInString];

                    // Count how many times the letter is used
                    for (int compareIndex = placeInString + 1; compareIndex < str.Length; compareIndex++)
                    {
                        if (currentLetter == str[compareIndex])
                        {
                            counter++;
                        }
                    }

                    // Write time or times, depending on counter value
                    if (counter == 1)
                    {
                        lineOfInfo = string.Format(currentLetter + " is found {0} time", counter);
                    }
                    else
                    {
                        lineOfInfo = string.Format(currentLetter + " is found {0} times", counter);
                    }

                    // Add each line of text to a list of strings
                    lettersInfo.Add(lineOfInfo);
                }
            }
        }

        return lettersInfo.ToArray();
    }

    public static bool CheckIfUsed(char[] usedLetters, char currentWord)
    {
        bool notUsed = true;

        foreach (char word in usedLetters)
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