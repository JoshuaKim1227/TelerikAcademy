using System;
using System.Collections.Generic;

public class BinaryToDecimal
{
    public static void Main()
    {
        List<int> bitsList = GetUserInput();

        VisualizeNumbers(bitsList);

        int number = ConvertBinaryToDecimal(bitsList);

        PrintResult(number);
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

        return bitsList;
    }

    public static void VisualizeNumbers(List<int> bits)
    {
        // Add zeroes if the input number is shorter than 32 bits
        if (bits.Count < 32)
        {
            bits.Reverse();

            for (int index = bits.Count; index <= 32; index++)
            {
                bits.Add(0);
            }

            bits.Reverse();
        }

        Console.Write("\nThe Binary number you entered is: ");
        foreach (int bit in bits)
        {
            Console.Write(bit);
        }

        Console.WriteLine();
    }

    public static int ConvertBinaryToDecimal(List<int> bits)
    {
        bool isNegative = false;
        int number = 1;
        int finalNumber = 0;

        if (bits.Count == 32 && bits[0] == 1)
        {
            bits[0] = 0;
            isNegative = true;
        }

        bits.Reverse();

        for (int bitPlace = 0; bitPlace < bits.Count; bitPlace++)
        {
            if (bits[bitPlace] == 1)
            {
                for (int power = bitPlace; power > 0; power--)
                {
                    number = number * 2;
                }

                finalNumber = finalNumber + number;
                number = 1;
            }
        }

        if (isNegative)
        {
            finalNumber = int.MinValue + finalNumber;
        }

        return finalNumber;
    }

    public static void PrintResult(int number)
    {
        Console.Write("The decimal representation of your number is: {0}\n", number);
    }
}