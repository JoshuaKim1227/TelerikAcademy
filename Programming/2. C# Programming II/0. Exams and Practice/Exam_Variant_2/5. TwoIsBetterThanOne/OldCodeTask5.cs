//using System;
//using System.Collections.Generic;

//class TwoIsBetterThanOne
//{
//    static void Main()
//    {
//        ulong[] task1Input = Task1GetInput();

//        int[] task2InputLine1 = Task2GetFirstLine();
//        int task2InputLine2 = int.Parse(Console.ReadLine());

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

//        int luckyNumbersCounter = 0;

//        bool isCondidate = false;

//        for (ulong number = downBorder; number <= upBorder; number++)
//        {
//            string numberToCheck = number.ToString();

//            for (int digit = 0; digit < numberToCheck.Length; digit++)
//            {
//                if (numberToCheck[digit] != '3' && numberToCheck[digit] != '5')
//                {
//                    break;
//                }
//                if (digit == numberToCheck.Length - 1)
//                {
//                    isCondidate = true;
//                }
//            }

//            if (isCondidate)
//            {
//                char[] numCharArr = numberToCheck.ToCharArray();
//                string reversedNumber = "";
//                Array.Reverse(numCharArr);

//                foreach (char ch in numCharArr)
//                {
//                    reversedNumber += ch;
//                }

//                if (numberToCheck == reversedNumber)
//                {
//                    luckyNumbersCounter++;
//                }
//            }
//            isCondidate = false;
//        }

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
//}