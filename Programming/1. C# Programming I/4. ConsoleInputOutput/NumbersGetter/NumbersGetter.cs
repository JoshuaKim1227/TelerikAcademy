using System;

class NumbersGetter
{
    static void Main()
    {
        int numCount;
        int numToAdd;
        int result = 0;

        Console.WriteLine("How many numbers do you like to add: ");
        numCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < numCount; i++)
        {
            Console.WriteLine("Enter a number: ");
            numToAdd = int.Parse(Console.ReadLine());
            result = result + numToAdd;
        }
        Console.WriteLine("The sum of all the numbers is {0}", result);
    }
}
