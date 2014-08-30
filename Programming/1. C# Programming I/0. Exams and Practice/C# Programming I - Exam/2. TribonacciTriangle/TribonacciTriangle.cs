using System;

class TribonacciTriangle
{
    static void Main()
    {
        // Inizializing variables
        int[] startingSeqNums = new int[3];
        int lineCount = 1;
        int sequenceLength = 1;
        int currentIndex = 0;

        // Getting input
        for (int i = 0; i < 3; i++)
        {
            startingSeqNums[i] = int.Parse(Console.ReadLine());
        }
        lineCount = int.Parse(Console.ReadLine());

        // Getting the length of the sequence
        for (int i = 1; i <= lineCount; i++)
        {
            sequenceLength += i;
        }

        // Transfering the numbers to the final array
        long[] finalSeqNums = new long[sequenceLength];

        for (int i = 0; i < startingSeqNums.Length; i++)
        {
            finalSeqNums[i] = startingSeqNums[i];
        }

        // Calculating the Tribonacci numbers
        for (int i = 3; i < finalSeqNums.Length; i++)
        {
            finalSeqNums[i] = finalSeqNums[i - 1] + finalSeqNums[i - 2] + finalSeqNums[i - 3];
        }

        // Printing the Tribonacci Triangle
        for (int i = 0; i < lineCount; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                if (j == 0)
                {
                    Console.Write(finalSeqNums[currentIndex]);
                    currentIndex++;
                }
                else
                {
                    Console.Write(" " + finalSeqNums[currentIndex]);
                    currentIndex++;
                }
            }
            Console.WriteLine();
        } 
    }
}

