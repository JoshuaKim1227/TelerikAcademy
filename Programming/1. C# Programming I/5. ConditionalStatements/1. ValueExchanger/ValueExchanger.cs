using System;

class ValueExchanger
{
    static void Main()
    {
        int firstNum;
        int secondNum;
        int tempValueHolder;

        Console.WriteLine("Please enter first number: ");
        firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter second number: ");
        secondNum = int.Parse(Console.ReadLine());

        Console.WriteLine("Your numbers are: {0} and {1}", firstNum, secondNum);

        if (firstNum != secondNum)
        {
            tempValueHolder = firstNum;
            firstNum = secondNum;
            secondNum = tempValueHolder;

            Console.WriteLine("The exchanged numbers are: {0} and {1}", firstNum, secondNum);
        }
        else
        {
            Console.WriteLine("Can't exchange!");
        }
    }
}

