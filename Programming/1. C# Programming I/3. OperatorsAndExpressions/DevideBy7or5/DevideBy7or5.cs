using System;

class DevideBy7or5
{
    static void Main()
    {
        int userInput;
        Console.WriteLine("Please enter a number to check: ");
        userInput = int.Parse(Console.ReadLine());

        if ((userInput % 5 == 0) && (userInput % 7 == 0))
        {
            Console.WriteLine("The number {0} can be devided by 5 and 7.", userInput);
        }
        else
        {
            Console.WriteLine("The number {0} can NOT be devided by 5 and 7.", userInput);
        }
    }
}

