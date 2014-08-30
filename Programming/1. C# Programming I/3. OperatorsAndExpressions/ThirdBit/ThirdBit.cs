using System;

class ThirdBit
{
    static void Main()
    {
        int position = 3;
        int userNum;
        int compareBits;
        int bit;

        Console.WriteLine("Enter a number to check: ");
        userNum = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        compareBits = userNum & mask;
        bit = compareBits >> 3;
        
        Console.WriteLine("The bit is: {0}" ,bit);
    }
}

