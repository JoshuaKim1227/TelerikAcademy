using System;

class IsSeven
{
    static void Main()
    {
        int userInput;
        int findThirdDigit;

        bool isThirdDigitSeven;

        Console.WriteLine("Please enter a number: ");
        userInput = int.Parse(Console.ReadLine());

        findThirdDigit = userInput / 100;

        if (findThirdDigit % 10 == 7)
        {
            isThirdDigitSeven = true;
        }
        else
        {
            isThirdDigitSeven = false;
        }
        Console.WriteLine(isThirdDigitSeven);
    }
}

