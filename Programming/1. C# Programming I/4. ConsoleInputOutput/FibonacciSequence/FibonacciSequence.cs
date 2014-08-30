using System;

class FibonacciSequence
{
    static void Main()
    {
        decimal firstNum = 0;
        decimal secondNum = 1;
        decimal result;

        for (int i = 0; i <= 100; i++)
        {
            result = firstNum + secondNum;
            firstNum = secondNum;
            secondNum = result;
            Console.WriteLine(firstNum);
        }
    }
}
