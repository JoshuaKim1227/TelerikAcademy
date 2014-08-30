using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

class NineGagNumbers
{
    static void Main()
    {
        string input = Console.ReadLine();
        int[] nineGagDigits = ExtractDigits(input);
        BigInteger result = ConvertToDecimal(nineGagDigits);
        Console.WriteLine(result);
    }

    static int[] ExtractDigits(string input)
    {
        string[] NineGagDigits = new string[9] { "-!", "**", "!!!", "&&", "&-", "!-", "*!!!", "&*!", "!!**!-" };
        List<int> NineGagNumber = new List<int>();

        StringBuilder builder = new StringBuilder();

        for (int symbol = 0; symbol < input.Length; symbol++)
        {
            builder.Append(input[symbol]);

            for (int digit = 0; digit < NineGagDigits.Length; digit++)
            {
                if (builder.ToString() == NineGagDigits[digit])
                {
                    NineGagNumber.Add(digit);
                    builder.Clear();
                }
            }
        }

        NineGagNumber.Reverse();

        return NineGagNumber.ToArray();
    }

    static BigInteger ConvertToDecimal(int[] nineGagNum)
    {
        BigInteger result = 0;

        for (int digit = 0; digit < nineGagNum.Length; digit++)
        {
            result += (BigInteger)nineGagNum[digit] * BigInteger.Pow(9, digit);
        }

        return result;
    }
}
