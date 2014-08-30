using System;

class GreatestOfFive
{
    static void Main()
    {
        int[] userNum = new int[5];
        int biggestNum = 0;

        Console.WriteLine("Please enter five numbers (on a separate line): ");

        for (int i = 0; i < userNum.Length; i++)
        {
            userNum[i] = int.Parse(Console.ReadLine());
            if (biggestNum < userNum[i])
            {
                biggestNum = userNum[i];
            }
        }
        Console.WriteLine("The biggest number is: {0}", biggestNum);
    }
}
