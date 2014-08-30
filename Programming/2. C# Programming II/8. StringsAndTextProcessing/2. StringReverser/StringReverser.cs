using System;
using System.Text;

public class StringReverser
{
    public static void Main()
    {
        string input;
        string result;

        input = ReadInput();
        result = ReverseString(input);

        PrintResult(result);
    }

    public static string ReadInput()
    {
        string userInput;

        Console.Write("Please enter a string:\n");
        userInput = Console.ReadLine();

        return userInput;
    }

    public static string ReverseString(string str)
    {
        string reversed = string.Empty;

        for (int index = str.Length - 1; index >= 0; index--)
        {
            reversed = reversed + str[index];
        }

        return reversed;
    }

    public static void PrintResult(string result)
    {
        Console.WriteLine("\nThe reversed string is:\n{0}", result);
    }
}