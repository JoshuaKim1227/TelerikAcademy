using System;

class GreaterOfTwoNumbers
{
    static void Main()
    {
        int firstNum;
        int secondNum;
        int result;

        Console.WriteLine("Please enter the first number to compare: ");
        firstNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second number to compare: ");
        secondNum = int.Parse(Console.ReadLine());

        result = Math.Max(firstNum, secondNum);
        Console.WriteLine("The greater number is {0}", result);
    }
}
