using System;
using System.Text;

public class BracketsChecker
{
    public static void Main()
    {
        string input;
        bool result;

        input = ReadInput();
        result = CheckBrackets(input);

        PrintResult(input, result);
    }

    public static string ReadInput()
    {
        string userInput;

        Console.Write("Please enter an expression: ");
        userInput = Console.ReadLine();

        return userInput;
    }

    public static bool CheckBrackets(string str)
    {
        int countBrackets = 0;
        bool result;

        for (int index = 0; index < str.Length; index++)
        {
            if (str[index] == '(')
            {
                countBrackets++;
            }

            if (str[index] == ')')
            {
                countBrackets--;
            }

            if (countBrackets < 0)
            {
                break;
            }
        }

        if (countBrackets == 0)
        {
            result = true;
        }
        else
        {
            result = false;
        }

        return result;
    }

    public static void PrintResult(string expression, bool result)
    {
        Console.WriteLine("\nThe expression {0} is with correct brackets: {1}", expression, result);
    }
}