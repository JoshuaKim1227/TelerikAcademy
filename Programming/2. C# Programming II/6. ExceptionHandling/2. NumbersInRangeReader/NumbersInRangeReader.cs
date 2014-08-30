using System;

public class NumbersInRangeReader
{
    public static void Main()
    {
        int startNum = 1;
        int endNum = 100;
        int number;

        try
        {
            for (int counter = 0; counter < 10; counter++)
            {
                number = ReadNumber(startNum, endNum);
                startNum = number + 1;
                Console.Write("The number is: {0}\n", number);
            }
        }
        catch (ArgumentOutOfRangeException outOfRangeEx)
        {
            Console.WriteLine(outOfRangeEx.Message + "\nValid range is {0}...{1}", startNum, endNum);
        }
        catch (OverflowException overflowEx)
        {
            Console.WriteLine(overflowEx.Message + "\nValid range is {0}...{1}", startNum, endNum);
        }
        catch (FormatException formatEx)
        {
            Console.WriteLine(formatEx.Message + "\nYou must enter an integer in the range of {0}...{1}", startNum, endNum);
        }
    }

    public static int ReadNumber(int start, int end)
    {
        Console.Write("Enter an integer number in the range of {0}...{1}: ", start, end);
        int userNum = int.Parse(Console.ReadLine());

        if (userNum < start || userNum > end)
        { 
            throw new ArgumentOutOfRangeException();
        }

        return userNum;
    }
}