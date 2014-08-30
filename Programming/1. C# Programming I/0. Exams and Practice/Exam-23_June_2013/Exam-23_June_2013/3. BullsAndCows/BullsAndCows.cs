using System;
using System.Collections.Generic;
using System.Text;

public class BullsAndCows
{
    public static void Main()
    {
        string inputNum = Console.ReadLine();
        int bulls = int.Parse(Console.ReadLine());
        int cows = int.Parse(Console.ReadLine());

        int currentBulls = 0;
        int currentCows = 0;

        for (int counter = 1111; counter <= 9999; counter++)
        {  
            string guessNum = counter.ToString();
            string secretNum = inputNum;

            if (guessNum.Contains("0"))
            {
                continue;
            }

            for (int bullMatcher = 0; bullMatcher < secretNum.Length; bullMatcher++)
            {
                if (guessNum[bullMatcher] == secretNum[bullMatcher])
                {
                    currentBulls++;

                    guessNum = guessNum.Remove(bullMatcher, 1);
                    guessNum = guessNum.Insert(bullMatcher, "*");

                    secretNum = secretNum.Remove(bullMatcher, 1);
                    secretNum = secretNum.Insert(bullMatcher, "*");
                }
            }

            for (int cowMatcher = 0; cowMatcher < secretNum.Length; cowMatcher++)
            {
                for (int cowSearcher = 0; cowSearcher < secretNum.Length; cowSearcher++)
                {
                    if (guessNum[cowMatcher] == secretNum[cowSearcher] && guessNum[cowMatcher] != '*')
                    {
                        currentCows++;
                        break;
                    }
                }
            }

            if (currentBulls == bulls && currentCows == cows)
            {
                Console.Write("{0} ", counter);
            }

            currentBulls = 0;
            currentCows = 0;
        }
    }
}