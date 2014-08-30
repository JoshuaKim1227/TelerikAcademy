using System;

class DevisionBy5
{
    static void Main()
    {
        int lowerNum;
        int higherNum;
        int p = 0;

        Console.WriteLine("Please enter a positive number: ");
        lowerNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a higher positive number than the above: ");
        higherNum = int.Parse(Console.ReadLine());

        for (int i = lowerNum; i <= higherNum; i++)
        {
            if (i % 5 == 0)
            {
                p++;
            }
        }

        Console.WriteLine("There are {0} numbers devideble by 0 between the two numbers you entered!", p);
    }
}

