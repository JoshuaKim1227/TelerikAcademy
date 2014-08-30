using System;
using System.Collections.Generic;

public class DecimalToBinary
{
    public static void Main()
    {
        short num = GetUserInput();
        List<short> binaryNumber = ConvertDecimalToBinary(num);
        PrintResult(binaryNumber, num);
    }

    public static short GetUserInput()
    {
        short userInput;

        Console.Write("Please enter a 16-bit whole number (other than 0): ");

        while (!short.TryParse(Console.ReadLine(), out userInput) || userInput == 0)
        {
            Console.WriteLine("\nInvalid Input!");
            Console.Write("Please enter a whole number: ");
        }

        return userInput;
    }

    public static List<short> ConvertDecimalToBinary(short number)
    {
        short remainder = 0;
        bool addOne = false;
        List<short> binaryNum = new List<short>();

        if (number < 0)
        {
            addOne = true;
            number = (short)(number + short.MinValue);
        }

        while (number > 0)
        {
            remainder = (short)(number % 2);
            number = (short)(number / 2);

            if (remainder > 0)
            {
                binaryNum.Add(1);
            }
            else
            {
                binaryNum.Add(0);
            }
        }

        if (addOne)
        {
            binaryNum.Add(1);
        }

        binaryNum.Reverse();

        return binaryNum;
    }

    public static void PrintResult(List<short> number, short userNum)
    {
        int counter = 0;
        Console.Write("\nThe Binary representation of {0} is: ", userNum);

        number.Reverse();
        if (number.Count < 16)
        {
            for (int i = number.Count; i < 16; i++)
            {
                number.Add(0);
            }
        }

        number.Reverse();

        foreach (short bit in number)
        {
            Console.Write(bit);
            counter++;

            if (counter % 4 == 0)
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }
}