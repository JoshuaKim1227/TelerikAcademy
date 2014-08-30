using System;
using System.Text;

public class ToUnicodeConverter
{
    public static void Main()
    {
        string text = "This is a test string.";
        string result = string.Empty;

        Console.WriteLine("The initial text is: {0}", text);
        char[] unicodeChars = text.ToCharArray();

        for (int index = 0; index < unicodeChars.Length; index++)
        {
            result = result + string.Format(@"\u{0:0000}", (int)unicodeChars[index]);
        }

        Console.WriteLine("\nThe unicode symbols are:\n{0}", result);
    }
}