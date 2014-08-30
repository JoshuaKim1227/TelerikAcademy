using System;
using System.Collections.Generic;

public class DecimalToHexadecimal
{
    // Not working for negative decimal numbers
    public static void Main()
    {
        int decNum = 1463374;
        Console.Write("The decimal number is: {0}", decNum);
        string hexSrt = ConvertDecimalToHexadecimal(decNum);
        hexSrt = ReverseString(hexSrt);
        Console.WriteLine("\nThe hexadecimal representation is: {0}", hexSrt);
    }

    public static string ReverseString(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }

    public static string ConvertDecimalToHexadecimal(int number)
    {
        int remainder = 0;
        string hexNumStr = null;

        if (number < 0)
        {
            number = number + int.MinValue;
        }

        while (number > 0)
        {
            remainder = number % 16;
            number = number / 16;

            if (remainder < 10)
            {
                hexNumStr = hexNumStr + remainder;
            }
            else
            {
                switch (remainder)
                {
                    case 10:
                        hexNumStr = hexNumStr + "A";
                        break;
                    case 11:
                        hexNumStr = hexNumStr + "B";
                        break;
                    case 12:
                        hexNumStr = hexNumStr + "C";
                        break;
                    case 13:
                        hexNumStr = hexNumStr + "D";
                        break;
                    case 14:
                        hexNumStr = hexNumStr + "E";
                        break;
                    case 15:
                        hexNumStr = hexNumStr + "F";
                        break;
                    default:
                        break;
                }
            }
        }

        return hexNumStr;
    }
}