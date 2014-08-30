using System;
using System.Text;

public static class StringBuilderSubstring
{
    public static StringBuilder Substring(this StringBuilder sb, int index, int length)
    {
        StringBuilder substring = new StringBuilder();

        if (index >= 0 && index < sb.Length)
        {
            substring.Append(sb.ToString(), index, length);
            return substring;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}
