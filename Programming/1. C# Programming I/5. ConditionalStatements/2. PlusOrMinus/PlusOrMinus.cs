using System;

class PlusOrMinus
{
    static void Main()
    {
        int numA;
        int numB;
        int numC;
        int signCount = 0;

        bool isPositive;

        Console.WriteLine("Please enter the first number: ");
        numA = int.Parse(Console.ReadLine());
  
        Console.WriteLine("Please enter the second number: ");
        numB = int.Parse(Console.ReadLine());
     
        Console.WriteLine("Please enter the third number: ");
        numC = int.Parse(Console.ReadLine());

        if (numA > 0)
        {
            signCount++;
        }
        else
        {
            signCount--;
        }

        if (numB > 0)
        {
            signCount++;
        }
        else
        {
            signCount--;
        }

        if (numC > 0)
        {
            signCount++;
        }
        else
        {
            signCount--;
        }

        if ((signCount == -3) || (signCount == 1))
        {
            isPositive = false;
        }
        else
        {
            isPositive = true;
        }

        if (numA == 0 | numB == 0 | numC == 0)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            Console.WriteLine("The result is positive: {0}", isPositive);
        }     
    }
}

