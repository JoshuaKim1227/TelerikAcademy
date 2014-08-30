using System;
using System.Text;

public class AsteriskIfLessThan20
{
    public static void Main()
    {
        string inputText;
        string result;

        inputText = "We made a";
        Console.WriteLine("The initial text is: {0}", inputText);

        result = ManageString(inputText);

        Console.WriteLine("\nThe result is: {0}", result);
    }

    public static string ManageString(string text)
    {
        StringBuilder builder = new StringBuilder(text);
        int asteriskCount = 20 - builder.Length;

        if (builder.Length < 20)
        {
            for (int index = 0; index < asteriskCount; index++)
            {
                builder.Append("*");
            }
        }

        return builder.ToString();
    }
}