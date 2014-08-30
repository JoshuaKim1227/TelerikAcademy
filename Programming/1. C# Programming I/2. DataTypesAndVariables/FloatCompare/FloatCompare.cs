using System;

class FloatCompare
{
    static void Main()
    {
        decimal firstNum;
        decimal secondNum;

        Console.Write("Enter first number to compare: ");
        firstNum = decimal.Parse(Console.ReadLine());
        Console.Write("Enter second number to compare: ");
        secondNum = decimal.Parse(Console.ReadLine());

      
        firstNum = Math.Truncate(firstNum * 1000000) / 1000000;
        secondNum = Math.Truncate(secondNum * 1000000) / 1000000;

        Console.WriteLine("\nComparing numbers: {0} and {1}", firstNum, secondNum);
        Console.WriteLine("The numbers are equal: " + (firstNum == secondNum));
    }
}

