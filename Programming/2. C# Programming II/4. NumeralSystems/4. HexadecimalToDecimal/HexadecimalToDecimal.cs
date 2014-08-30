using System;
using System.Collections.Generic;

public class HexadecimalToDecimal
{
    public static void Main()
    {
        string hex = "FFFFFFFFFFFFFF83";
        Console.Write("The hexadecimal number is: {0}", hex);
        List<int> numbersList = ConvertLettersToNumbers(hex);
        int result = ConvertBinaryToDecimal(numbersList);

        Console.WriteLine("\nThe decimal representation is: {0}", result);
    }

    public static List<int> ConvertLettersToNumbers(string strToConvers)
    {
        int digit;
        List<int> hexNumbers = new List<int>();
        char[] charArray = strToConvers.ToCharArray();

        for (int index = 0; index < charArray.Length; index++)
        {
            if (int.TryParse(charArray[index].ToString(), out digit))
            {
                hexNumbers.Add(digit);
            }
            else
            {
                switch (charArray[index])
                {
                    case 'A':
                        hexNumbers.Add(10);
                        break;
                    case 'B':
                        hexNumbers.Add(11);
                        break;
                    case 'C':
                        hexNumbers.Add(12);
                        break;
                    case 'D':
                        hexNumbers.Add(13);
                        break;
                    case 'E':
                        hexNumbers.Add(14);
                        break;
                    case 'F':
                        hexNumbers.Add(15);
                        break;
                    default:
                        break;
                }
            }
        }

        return hexNumbers;
    }

    public static int ConvertBinaryToDecimal(List<int> hexNum)
    {
        int number = 1;
        int finalNumber = 0;

        hexNum.Reverse();

        for (int placeInNum = 0; placeInNum < hexNum.Count; placeInNum++)
        {
            number = hexNum[placeInNum] * ((int)Math.Pow(16, placeInNum));

            finalNumber = finalNumber + number;
        }

        return finalNumber;
    }
}