using System;

public class LongestSequenceOfStrings
{
    public static void Main()
    {
        // Inizializing data types and getting user input
        int bestSequence = int.MinValue;
        int tempSequence = 1;
        string elementInSeqence = null;

        int indexA = 0;
        int indexB = 0;

        string[,] array = new string[,] 
        {
            { "ha", "fifi", "ho", "hi" },
            { "fo", "ha", "hi", "xx" },
            { "xxx", "hi", "ha", "xx" }
        };

        // Visualising the initial array
        Console.WriteLine("The initial matrix is:");
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                if (array[row, col].Length == 4)
                {
                    Console.Write(array[row, col] + " ");
                }
                else if (array[row, col].Length == 3)
                {
                    Console.Write(array[row, col] + "  ");
                }
                else
                {
                    Console.Write(array[row, col] + "   ");
                }
            }

            Console.WriteLine();
        }

        // Iterating through the array - generating starting point
        for (int row = 0; row < array.GetLength(0); row++)
        {
            for (int col = 0; col < array.GetLength(1); col++)
            {
                // Checking verticals for sequences
                for (int verticalCheck = row; verticalCheck < array.GetLength(0) - 1; verticalCheck++)
                {
                    if (array[verticalCheck, col] == array[verticalCheck + 1, col])
                    {
                        tempSequence++;
                        if (bestSequence < tempSequence)
                        {
                            bestSequence = tempSequence;
                            elementInSeqence = array[verticalCheck, col];
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                tempSequence = 1;

                // Checking horizontals for sequences
                for (int horizontalCheck = col; horizontalCheck < array.GetLength(1) - 1; horizontalCheck++)
                {
                    if (array[row, horizontalCheck] == array[row, horizontalCheck + 1])
                    {
                        tempSequence++;
                        if (bestSequence < tempSequence)
                        {
                            bestSequence = tempSequence;
                            elementInSeqence = array[row, horizontalCheck];
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                tempSequence = 1;

                // Checking verticals-down for sequences
                indexA = row;
                indexB = col;

                while (indexA < array.GetLength(0) - 1 && indexB < array.GetLength(1) - 1)
                {
                    if (array[indexA, indexB] == array[indexA + 1, indexB + 1])
                    {
                        tempSequence++;
                        if (bestSequence < tempSequence)
                        {
                            bestSequence = tempSequence;
                            elementInSeqence = array[row, col];
                        }
                    }
                    else
                    {
                        break;
                    }

                    indexA++;
                    indexB++;
                }

                tempSequence = 1;

                // Checking verticals-up for sequences
                indexA = row;
                indexB = col;

                while (indexA > 0 && indexB < array.GetLength(1) - 1)
                {
                    if (array[indexA, indexB] == array[indexA - 1, indexB + 1])
                    {
                        tempSequence++;
                        if (bestSequence < tempSequence)
                        {
                            bestSequence = tempSequence;
                            elementInSeqence = array[row, col];
                        }
                    }
                    else
                    {
                        break;
                    }

                    indexA--;
                    indexB++;
                }

                tempSequence = 1;
            }
        }

        // Printing the result
        Console.WriteLine("\nLongest sequence is:");
        for (int i = 0; i < bestSequence; i++)
        {
            if (i < bestSequence - 1)
            {
                Console.Write(elementInSeqence + ", ");
            }
            else
            {
                Console.Write(elementInSeqence);
            }
        }

        Console.WriteLine();
    }
}