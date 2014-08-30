using System;

class BiggerOfTree
{
    static void Main()
    {
        int numA;
        int numB;
        int numC;

        Console.WriteLine("Please enter tree numbers (on a separate line): ");
        numA = int.Parse(Console.ReadLine());
        numB = int.Parse(Console.ReadLine());
        numC = int.Parse(Console.ReadLine());

        int biggerNum = numA;

        if (numB > biggerNum)
        {
            biggerNum = numB;
        }
        if (numC > biggerNum)
        {
            biggerNum = numC;
        }
        Console.WriteLine("The biggest number is: {0}", biggerNum);
    }
}
