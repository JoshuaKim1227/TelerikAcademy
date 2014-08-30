using System;

class IsBitOne
{
    static void Main()
    {
        int position;
        int num;
        int bitCheck;
        int result;
        bool isOne = false;

        Console.WriteLine("Please enter a number: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("Which bit to check: ");
        position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        bitCheck = num & mask;
        result = bitCheck >> position;
        if (result == 1)
        {
            isOne = true;
            Console.WriteLine("Is the bit at the choosen position 1? {0}", isOne);
        }
        else
        {
            Console.WriteLine("Is the bit at the choosen position 1? {0}", isOne);
        }
    }
}

