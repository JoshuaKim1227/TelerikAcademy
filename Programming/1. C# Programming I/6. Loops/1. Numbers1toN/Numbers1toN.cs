using System;

class Numbers1toN
{
    static void Main()
    {
        int userInput;
        
        Console.WriteLine("Please enter a positive number: ");
        userInput = int.Parse(Console.ReadLine());

        for (int i = 1; i <= userInput; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}
