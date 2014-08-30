using System;

public class BiggestOfThree
{
    // Inizializing Variables
    static int[] numArray = new int[3];
    
    static int firstNum;
    static int secondNum;
    static int thirdNum;

    public static void Main()
    {
        Console.Write("Enter first number: ");
        firstNum = ReadInput();
        Console.Write("Enter second number: ");
        secondNum = ReadInput();
        Console.Write("Enter third number: ");
        thirdNum = ReadInput();

        if (AreComparable())
        {
            int biggerOfTwo = GetMax(firstNum, secondNum);
            PrintResult(GetMax(biggerOfTwo, thirdNum));            
        }
        else
        {
            Console.WriteLine("The numbers are not comparable.");
        }
    }

    public static int ReadInput()
    {
        return int.Parse(Console.ReadLine());
    }

    public static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    public static bool AreComparable()
    {
        if (firstNum == secondNum || firstNum == thirdNum || secondNum == thirdNum)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static void PrintResult(int number)
    {
        Console.WriteLine("\nThe biggest number is: {0}", number);
    }
}