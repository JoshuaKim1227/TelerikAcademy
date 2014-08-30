using System;
using System.Numerics;
using System.Collections.Generic;

class DurankulakNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();

        ulong result = ConvertNumber(input);

        Console.WriteLine(result);
    }

    static ulong ConvertNumber(string input)
    {
        const int alphabetLength = 26;

        List<int> decNumbersList = new List<int>();

        int lowerCaseDecDigit = 0;
        int UpperCaseDecNumber = 0;
        int lowerCaseDecNumber = 0;

        int decNumber = 0;

        ulong finalDecNumber = 0;

        char[] duranNum = input.ToCharArray();

        for (int letter = 0; letter < duranNum.Length; letter++)
        {
            if ((int)duranNum[letter] >= 97 && (int)duranNum[letter] <= 122)
            {
                lowerCaseDecDigit = (int)duranNum[letter] - 96;

                lowerCaseDecNumber = lowerCaseDecDigit * alphabetLength;

                letter++;
            }
            if ((int)duranNum[letter] >= 65 && (int)duranNum[letter] <= 90)
            {
                UpperCaseDecNumber = (int)duranNum[letter] - 65;

                if (lowerCaseDecNumber != 0)
                {
                    decNumber = lowerCaseDecNumber + UpperCaseDecNumber;
                    decNumbersList.Add(decNumber);
                }
                else
                {
                    decNumber = UpperCaseDecNumber;
                    decNumbersList.Add(decNumber);
                }
            }

            lowerCaseDecDigit = 0;
            lowerCaseDecNumber = 0;
            UpperCaseDecNumber = 0;
            decNumber = 0;
        }

        decNumbersList.Reverse();

        for (int placeInNum = 0; placeInNum < decNumbersList.Count; placeInNum++)
        {
            finalDecNumber += (ulong)decNumbersList[placeInNum] * (ulong)(BigInteger.Pow(168, placeInNum));
        }

        return finalDecNumber;
    }
}

