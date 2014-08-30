using System;
using System.Collections.Generic;

public static class AddingArraysOfDigits
{
    static int firstNumLength;
    static int secondNumLength;
    static int[] firstNumDigits;
    static int[] secondNumDigits;
    static List<int> resultArray;
    static Random rand = new Random();

    public static void Main()
    {
        firstNumLength = GetUserInput(firstNumLength);
        secondNumLength = GetUserInput(secondNumLength);

        firstNumDigits = RandomFillArray(firstNumDigits, firstNumLength);
        secondNumDigits = RandomFillArray(secondNumDigits, secondNumLength);

        Console.WriteLine();
        VisualizeNumbers(firstNumDigits, secondNumDigits);

        resultArray = AddNumbers(firstNumDigits, secondNumDigits);

        Console.WriteLine("----------------------------");
        foreach (int number in resultArray)
        {
            Console.Write(number);
        }

        Console.WriteLine();
    }

    public static int GetUserInput(int numberLength)
    {
        numberLength = int.MaxValue;

        while (numberLength > 10000)
        {
            Console.WriteLine("Enter the length of the number (less than 10 000): ");
            numberLength = int.Parse(Console.ReadLine());
        }

        return numberLength;
    }

    public static int[] RandomFillArray(int[] array, int arrayLength)
    {
        array = new int[arrayLength];

        for (int i = arrayLength - 1; i >= 0; i--)
        {
            array[i] = rand.Next(1, 10);
        }

        return array;
    }

    public static void VisualizeNumbers(int[] firstNum, int[] secondNum)
    {
        for (int i = 0; i < firstNum.Length; i++)
        {
            Console.Write(firstNum[i]);
        }

        Console.WriteLine();
        Console.WriteLine("+");

        for (int i = 0; i < secondNum.Length; i++)
        {
            Console.Write(secondNum[i]);
        }

        Console.WriteLine();
    }

    public static List<int> AddNumbers(int[] firstNumArray, int[] secondNumArray)
    {
        List<int> result = new List<int>();
        int digit = 0;
        bool carry = false;

        int shorterArrayLength = 0;
        int longerArrayLength = 0;
        int longerArray = 0;

        if (firstNumArray.Length < secondNumArray.Length)
        {
            shorterArrayLength = firstNumArray.Length;
            longerArrayLength = secondNumArray.Length;
            longerArray = 2;
        }

        if (firstNumArray.Length > secondNumArray.Length)
        {
            shorterArrayLength = secondNumArray.Length;
            longerArrayLength = firstNumArray.Length;
            longerArray = 1;
        }

        if (firstNumArray.Length == secondNumArray.Length)
        {
            shorterArrayLength = firstNumArray.Length;
            longerArray = 0;
        }

        Array.Reverse(firstNumArray);
        Array.Reverse(secondNumArray);

        for (int index = 0; index < shorterArrayLength; index++)
        {
            if (!carry)
            {
                digit = firstNumArray[index] + secondNumArray[index];
            }
            else
            {
                digit = firstNumArray[index] + secondNumArray[index] + 1;
            }

            if (digit < 10)
            {
                result.Add(digit);
                carry = false;
            }
            else
            {
                digit = digit % 10;
                result.Add(digit);
                carry = true;
            }
        }

        if (carry && longerArray == 0)
        {
            result.Add(1);
        }

        if (longerArray != 0)
        {
            for (int index = shorterArrayLength; index < longerArrayLength; index++)
            {
                if (longerArray == 1)
                {
                    if (!carry)
                    {
                        digit = firstNumArray[index];
                    }
                    else
                    {
                        digit = firstNumArray[index] + 1;
                    }

                    if (digit < 10)
                    {
                        result.Add(digit);
                        carry = false;
                    }
                    else
                    {
                        digit = digit % 10;
                        result.Add(digit);
                        carry = true;
                    }
                }

                if (longerArray == 2)
                {
                    if (!carry)
                    {
                        digit = secondNumArray[index];
                    }
                    else
                    {
                        digit = secondNumArray[index] + 1;
                    }

                    if (digit < 10)
                    {
                        result.Add(digit);
                        carry = false;
                    }
                    else
                    {
                        digit = digit % 10;
                        result.Add(digit);
                        carry = true;
                    }
                }
            }

            if (carry)
            {
                result.Add(1);
            }
        }

        result.Reverse();
        return result;
    }
}