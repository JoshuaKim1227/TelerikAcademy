using System;
using System.Collections.Generic;

public class DecimalToBinary
{
    public static void Main()
    {
        int num = GetUserInput();
        List<int> binaryNumber = ConvertDecimalToBinary(num);
        PrintResult(binaryNumber, num);
    }

    public static int GetUserInput()
    {
        int userInput;

        Console.Write("Please enter a whole number (other than 0): ");

        while (!int.TryParse(Console.ReadLine(), out userInput) || userInput == 0)
        {
            Console.WriteLine("\nInvalid Input!");
            Console.Write("Please enter a whole number: ");
        }

        return userInput;
    }

    public static List<int> ConvertDecimalToBinary(int number)
    {
        int remainder = 0;
        bool addOne = false;
        List<int> binaryNum = new List<int>();

        if (number < 0)
        {
            number = number + int.MinValue;
            addOne = true;
        }

        while (number > 0)
        {
            remainder = number % 2;
            number = number / 2;

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

    public static void PrintResult(List<int> number, int userNum)
    {
        int counter = 0;

        Console.Write("\nThe Binary representation of {0} is: ", userNum);

        foreach (int bit in number)
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