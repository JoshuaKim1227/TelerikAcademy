using System;

public class DigitsReverser
{
    static int number;

    public static void Main()
    {
        number = GetUserInput();
        Console.WriteLine("\nThe reversed number is: {0}", ReverseDigits(number));
    }

    public static int GetUserInput()
    {
        Console.Write("Enter a positive number: ");
        return int.Parse(Console.ReadLine());
    }

    public static int ReverseDigits(int num)
    {
        int reversed = 0;
        while (num > 0)
        {
            reversed = (reversed * 10) + (num % 10);
            num = num / 10;
        }

        return reversed;
    }
}