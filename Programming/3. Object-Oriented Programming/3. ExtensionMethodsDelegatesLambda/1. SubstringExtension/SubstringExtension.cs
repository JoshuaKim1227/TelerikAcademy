using System;
using System.Text;

public class SubstringExtension
{
    public static void Main()
    {
        StringBuilder test = new StringBuilder("ThisIsATest.");

        string substr = test.Substring(2, 3).ToString();
        Console.WriteLine(substr);
    }
}
