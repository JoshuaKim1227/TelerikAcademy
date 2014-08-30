using System;
using System.Collections.Generic;

public class BinaryToHexadecimal
{
    public static void Main()
    {
        List<int> binaryList = GetUserInput();
        Console.Write("You entered: ");
        Visualize(binaryList);
        string finalResult = ConvertBinaryToHex(binaryList);
        Console.WriteLine("The hexadecimal representation is: {0}", finalResult);
    }

    public static List<int> GetUserInput()
    {
        List<int> bitsList = new List<int>();

        Console.Write("Please enter a sequence of bits (0 or 1):  ");

        string userInput = Console.ReadLine();
        char[] charArray = userInput.ToCharArray();

        foreach (char bit in charArray)
        {
            bitsList.Add(int.Parse(bit.ToString()));
        }

        while (bitsList.Count % 4 != 0)
        {
            bitsList.Add(0);
        }

        return bitsList;
    }

    public static void Visualize(List<int> bits)
    {
        int counter = 1;

        foreach (int digit in bits)
        {
            Console.Write(digit);

            if (counter % 4 == 0)
            {
                Console.Write(" ");
            }

            counter++;
        }

        Console.WriteLine();
    }

    public static string ConvertBinaryToHex(List<int> binList)
    {
        // Initializing data types 
        string tempHoder = null;
        string result = null;
        int fourDigits = 0;
        int digit;
        int index;

        // Get Binary digits four by four
        for (int hexDigit = binList.Count / 4; hexDigit > 0; hexDigit--)
        {
            for (int digitToTake = 3; digitToTake >= 0; digitToTake--)
            {
                index = (binList.Count - 1) - digitToTake;
                digit = binList[index];
                tempHoder = tempHoder + digit;
            }

            // Assign four digits in variable
            fourDigits = int.Parse(tempHoder);

            // Find the corresponding hexadecimal value and assign it to a string
            switch (fourDigits)
            {
                case 0000:
                    result = result + "0";
                    break;
                case 0001:
                    result = result + "1";
                    break;
                case 0010:
                    result = result + "2";
                    break;
                case 0011:
                    result = result + "3";
                    break;
                case 0100:
                    result = result + "4";
                    break;
                case 0101:
                    result = result + "5";
                    break;
                case 0110:
                    result = result + "6";
                    break;
                case 0111:
                    result = result + "7";
                    break;
                case 1000:
                    result = result + "8";
                    break;
                case 1001:
                    result = result + "9";
                    break;
                case 1010:
                    result = result + "A";
                    break;
                case 1011:
                    result = result + "B";
                    break;
                case 1100:
                    result = result + "C";
                    break;
                case 1101:
                    result = result + "D";
                    break;
                case 1110:
                    result = result + "E";
                    break;
                case 1111:
                    result = result + "F";
                    break;
                default:
                    break;
            }

            // Remove last four digits in the initial list
            for (int removeCount = 0; removeCount < 4; removeCount++)
            {
                binList.RemoveAt(binList.Count - 1);
            }

            // Set variables to 0
            tempHoder = null;
            fourDigits = 0;
        }

        // Reversing the resulting string
        char[] chaArray = result.ToCharArray();
        result = null;

        for (int j = chaArray.Length - 1; j >= 0; j--)
        {
            result = result + chaArray[j];
        }

        return result;
    }
}