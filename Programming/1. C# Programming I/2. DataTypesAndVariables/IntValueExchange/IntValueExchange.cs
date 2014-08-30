using System;

class IntValueExchange
{
    static void Main()
    {
        int firstValue = 5;
        int secondValue = 10;
        int tempValueHolder;

        tempValueHolder = firstValue;
        firstValue = secondValue;
        secondValue = tempValueHolder;

        Console.WriteLine("The exchanged values are: {0} {1}", firstValue, secondValue);
    }
}

