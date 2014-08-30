//using System;
//using System.Text;
//using System.Collections.Generic;

//class TwoIsBetterThanOne
//{
//    static void Main()
//    {
//        ulong[] task1Input = new ulong[2] { 100, 10000 };

//        int[] task2InputLine1 = new int[4] { -2, -1, -4, -3 };
//        int task2InputLine2 = 50;

//        int task1Result = SolveTask1(task1Input);
//        int task2Result = SolveTask2(task2InputLine1, task2InputLine2);

//        Console.WriteLine(task1Result);
//        Console.WriteLine(task2Result);
//    }

//    static ulong[] Task1GetInput()
//    {
//        string input = Console.ReadLine();

//        string[] numChars = input.Split(' ');

//        ulong[] numbers = new ulong[numChars.Length];

//        for (int num = 0; num < numChars.Length; num++)
//        {
//            numbers[num] = ulong.Parse(numChars[num]);
//        }

//        return numbers;
//    }

//    static int[] Task2GetFirstLine()
//    {
//        string input = Console.ReadLine();

//        string[] numChars = input.Split(',');

//        int[] numbers = new int[numChars.Length];

//        for (int num = 0; num < numChars.Length; num++)
//        {
//            numbers[num] = int.Parse(numChars[num]);
//        }

//        return numbers;
//    }

//    static int SolveTask1(ulong[] borderNums)
//    {
//        ulong downBorder = borderNums[0];
//        ulong upBorder = borderNums[1];

//        string numberStr = downBorder.ToString();
//        int digitsCount = numberStr.Length;
//        List<string> result = new List<string>();
//        List<string> output = new List<string>();
//        StringBuilder builder = new StringBuilder();

//        ConstructNumber(digitsCount, builder, output);

//        int luckyNumbersCounter = 0;

//        return luckyNumbersCounter;
//    }

//    static int SolveTask2(int[] numbers, int percent)
//    {
//        float percentOfElements = numbers.Length * ((float)percent / 100);

//        int roundedNum = (int)Math.Round(percentOfElements, 0);

//        Array.Sort(numbers);

//        int finalResult = numbers[roundedNum - 1];

//        return finalResult;
//    }

//    static void ConstructNumber(int digitsCount, StringBuilder builder, List<string> output)
//    {
//        string[] threeOrFive = new string[] { "3", "5" };
//        int counter = 0;

//        for (int placeInNum = 0; placeInNum < digitsCount; placeInNum++)
//        {
//            builder.Append(threeOrFive[placeInNum]);
//            ConstructNumber(digitsCount - 1, builder, output);
//        }

//        output.Add(builder.ToString());
//        builder.Clear();
//        counter++;

//        return;
//    }
//}