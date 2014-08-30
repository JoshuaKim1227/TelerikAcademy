using System;

class NotDevidableBy3And7
{
    static void Main()
    {
        int userInput;

        Console.WriteLine("Please enter a positive number: ");
        userInput = int.Parse(Console.ReadLine());

        for (int i = 0; i < userInput; i++)
        {
            if ((i % 3 == 0) && (i % 7 == 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}

