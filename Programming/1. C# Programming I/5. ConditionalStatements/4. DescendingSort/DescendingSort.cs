using System;

class DescendingSort
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

        if (numA > numB)
        {
            if (numA > numC)
            {
                if (numB > numC)
                {
                    Console.WriteLine("The numbers in descending order: {0} {1} {2}", numA, numB, numC);
                }
                else
                {
                    Console.WriteLine("The numbers in descending order: {0} {1} {2}", numA, numC, numB);
                }
            }
            else
            {
                if (numC > numB)
                {
                    Console.WriteLine("The numbers in descending order: {0} {1} {2}", numC, numB, numA);
                }
            }
        }
        else if (numB > numA)
        {
            if (numB > numC)
            {
                if (numA > numC)
                {
                    Console.WriteLine("The numbers in descending order: {0} {1} {2}", numB, numA, numC);
                }
                else
                {
                    Console.WriteLine("The numbers in descending order: {0} {1} {2}", numB, numC, numA);
                }
            }
            else
            {
                Console.WriteLine("The numbers in descending order: {0} {1} {2}", numC, numB, numA);
            }
        }
    }
}

