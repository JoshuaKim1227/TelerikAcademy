using System;
using System.Collections.Generic;

public class RandomGenerator
{
    public static int numbersCount = 10;
    public static int fromNumber = 100;
    public static int toNumber = 200;
    public static Random rand = new Random();
    public static List<int> numbers = new List<int>();

    public static void Main()
    {
        int num;

        for (int count = 0; count < numbersCount; count++)
        {
            num = GetRandomNumber(fromNumber, toNumber + 1);
            numbers.Add(num);
        }

        Console.WriteLine("10 random values from 100 to 200:");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }

    public static int GetRandomNumber(int fromNum, int toNum)
    {
        return rand.Next(fromNum, toNum);
    }
}