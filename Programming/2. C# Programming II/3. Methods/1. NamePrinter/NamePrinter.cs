using System;

public class NamePrinter
{
    public static void Main()
    {
        Console.Write("Enter your name: ");
        string userInput = GetInput();
        Console.WriteLine(NamePrint(userInput));
    }

    public static string GetInput()
    {
        string input;
        return input = Console.ReadLine();
    }

    public static bool ValidInput(string name)
    {
        string inputString = name;

        // Checking for digits 
        char[] array = inputString.ToCharArray();
        for (int i = 0; i < array.Length; i++)
        {
            if (char.IsDigit(array[i]))
            {
                return false;
            }           
        }

        // Checking for empty string
        if (string.IsNullOrEmpty(inputString))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static string NamePrint(string name)
    {
        if (ValidInput(name))
        {
            return "Hello, " + name + "!";
        }
        else
        {
            return "Invalid Input!";
        }
    }
}