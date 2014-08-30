using System;

public class LastDigitAsWord
{
    static string userInput;
    static char[] charArray;
    static string lastDigitWord;
    static int lastDigit;

    public static void Main()
    {
        Console.Write("Enter a number: ");
        userInput = GetUserInput();
        userInput = RemoveNegativeSign(userInput);
        lastDigit = GetLastDigit(userInput);
        lastDigitWord = ConvertLastDigitToWord(lastDigit);
        PrintTheResult(lastDigitWord);
    }

    public static string GetUserInput()
    {
        return Console.ReadLine();
    }

    public static string RemoveNegativeSign(string userString)
    {
        int number = int.Parse(userString);
        
        if (number < 0)
        {
            number = number - (2 * number);
        }

        return number.ToString();
    }

    public static int GetLastDigit(string userString)
    {
        charArray = userString.ToCharArray();
        int[] intArray = new int[charArray.Length];

        for (int i = 0; i < charArray.Length; i++)
        {
            intArray[i] = int.Parse(charArray[i].ToString());
        }

        return intArray[intArray.Length - 1];
    }

    public static string ConvertLastDigitToWord(int lastDigit)
    {
        string word;
        switch (lastDigit)
        {
            case 0:
                word = "zero";
                break;
            case 1:
                word = "one";
                break;
            case 2:
                word = "two";
                break;
            case 3:
                word = "three";
                break;
            case 4:
                word = "four";
                break;
            case 5:
                word = "five";
                break;
            case 6:
                word = "six";
                break;
            case 7:
                word = "seven";
                break;
            case 8:
                word = "eight";
                break;
            case 9:
                word = "nine";
                break;
            default:
                word = null;
                break;
        }

        return word;
    }

    public static void PrintTheResult(string result)
    {
        Console.WriteLine("\nThe last digit as a word is: {0}", result);
    }
}