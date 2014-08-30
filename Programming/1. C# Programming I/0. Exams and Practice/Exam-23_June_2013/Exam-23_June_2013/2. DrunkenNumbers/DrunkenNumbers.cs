using System;

public class DrunkenNumbers
{
    public static void Main()
    {
        // Get input and initialize variables
        int rounds = int.Parse(Console.ReadLine());
        string[] drunkenNums = new string[rounds];
        string leftHalf = string.Empty;
        string rightHalf = string.Empty;
        int mitkoBeers = 0;
        int vladkoBeers = 0;
        int mitkoScore = 0;
        int vladkoScore = 0;

        for (int drunkenNum = 0; drunkenNum < drunkenNums.Length; drunkenNum++)
        {
            drunkenNums[drunkenNum] = Console.ReadLine();
        }

        // Process the Drunken numbers
        for (int round = 0; round < rounds; round++)
        {
            // Check if number is only zeroes
            int cutIndex = 0;
            bool allZeroes = true;

            for (int digit = 0; digit < drunkenNums[round].Length; digit++)
            {
                if (drunkenNums[round][digit] != '0' && drunkenNums[round][digit] != '-')
                {
                    allZeroes = false;
                }
            }

            // If number is only zeroes, cut them out
            if (!allZeroes)
            {
                for (int index = 0; index < drunkenNums[round].Length; index++)
                {
                    if (drunkenNums[round][index] == '0' || drunkenNums[round][index] == '-')
                    {
                        cutIndex++;
                    }
                    else
                    {
                        break;
                    }
                }

                drunkenNums[round] = drunkenNums[round].Substring(cutIndex);

                cutIndex = 0;
            }

            if (drunkenNums[round].Length % 2 == 0) // If number is even
            {
                // Split the Drunken number into two parts
                leftHalf = drunkenNums[round].Substring(0, drunkenNums[round].Length / 2);
                rightHalf = drunkenNums[round].Substring(drunkenNums[round].Length / 2, drunkenNums[round].Length / 2);

                mitkoBeers = int.Parse(leftHalf);
                vladkoBeers = int.Parse(rightHalf);

                for (int digit = 0; digit < leftHalf.Length; digit++)
                {
                    mitkoScore += mitkoBeers % 10; // Take last digit
                    mitkoBeers = mitkoBeers / 10; // Remove last digit
                }

                for (int digit = 0; digit < rightHalf.Length; digit++)
                {
                    vladkoScore += vladkoBeers % 10; // Take last digit
                    vladkoBeers = vladkoBeers / 10; // Remove last digit
                }
            }
            else // If number is odd
            {
                leftHalf = drunkenNums[round].Substring(0, (drunkenNums[round].Length / 2) + 1);
                rightHalf = drunkenNums[round].Substring(drunkenNums[round].Length / 2, (drunkenNums[round].Length / 2) + 1);

                mitkoBeers = int.Parse(leftHalf);
                vladkoBeers = int.Parse(rightHalf);

                for (int digit = 0; digit < leftHalf.Length; digit++)
                {
                    mitkoScore += mitkoBeers % 10; // Take last digit
                    mitkoBeers = mitkoBeers / 10; // Remove last digit
                }

                for (int digit = 0; digit < rightHalf.Length; digit++)
                {
                    vladkoScore += vladkoBeers % 10; // Take last digit
                    vladkoBeers = vladkoBeers / 10; // Remove last digit
                }
            }
        }

        // Print the result
        if (mitkoScore > vladkoScore)
        {
            Console.WriteLine("M {0}", mitkoScore - vladkoScore);
        }
        else if (mitkoScore < vladkoScore)
        {
            Console.WriteLine("V {0}", vladkoScore - mitkoScore);
        }
        else
        {
            Console.WriteLine("No {0}", mitkoScore + vladkoScore);
        }
    }
}