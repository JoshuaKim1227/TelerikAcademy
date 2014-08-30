using System;

class BitHolder
{
    static void Main()
    {
        int userNum;
        int zeroOrOne;
        int position;
        int result;

        Console.WriteLine("Please enter  a number: ");
        userNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the position for the bit change: ");
        position = int.Parse(Console.ReadLine());
        Console.WriteLine("Should it be changed to 0 or 1: ");
        zeroOrOne = int.Parse(Console.ReadLine());

        if (zeroOrOne == 1)
        {
            int mask = 1 << position;
            result = userNum | mask;
            Console.WriteLine("The new number is: {0}", result);
        }
        else
        {
            int mask = ~(1 << position);
            result = userNum & mask;
            Console.WriteLine("The new number is: {0}", result);
        }
    }
}
