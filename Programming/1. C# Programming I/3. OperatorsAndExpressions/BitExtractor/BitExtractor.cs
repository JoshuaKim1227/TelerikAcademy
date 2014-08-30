using System;

class BitExtractor
{
    static void Main()
    {
        int userNum;
        int position;
        int result;
        int bitCheck;

        Console.WriteLine("Please enter a number: ");
        userNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a bit position: ");
        position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        result = userNum & mask;
        bitCheck = result >> position;
        Console.WriteLine("The value of the bit choosen is: {0}", bitCheck);
    }
}

