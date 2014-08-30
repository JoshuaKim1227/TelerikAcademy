using System;

public class MatrixFiller
{
    public static void Main()
    {
        // Inizializing data types and getting user input
        Console.Write("Please enter matrix size: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int counter = 0;
        int indexA = 0;
        int indexB = 0;

        // PART A
        // Writing the numbers in the array
        Console.Write("\nPart A");
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = (row + 1) + (col * n);
            }
        }

        Console.WriteLine();

        // Printing the result
        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                if (matrix[row, col] < 10)
                {
                    Console.Write(matrix[row, col] + "  ");
                }
                else
                {
                    Console.Write(matrix[row, col] + " ");
                }
            }

            Console.WriteLine();
        }

        // Clearing the array
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = 0;
            }
        }

        // PART B
        // Writing the numbers in the array
        Console.Write("\nPart B");
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = (row + 1) + (col * n);
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = (n - row) + (col * n);
                }
            }
        }

        Console.WriteLine();

        // Printing the result
        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                if (matrix[row, col] < 10)
                {
                    Console.Write(matrix[row, col] + "  ");
                }
                else
                {
                    Console.Write(matrix[row, col] + " ");
                }
            }

            Console.WriteLine();
        }

        // Clearing the array
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = 0;
            }
        }

        Console.WriteLine();

        // PART C
        // Writing the numbers starting from Col 0, Row 0++
        Console.Write("Part C\n");
        for (int startingPoint = matrix.GetLength(0) - 1; startingPoint >= 0; startingPoint--)
        {
            indexA = startingPoint;
            indexB = 0;
            while (indexA < matrix.GetLength(1) && indexB < matrix.GetLength(1))
            {
                counter++;
                matrix[indexA, indexB] = counter;
                indexA++;
                indexB++;
            }
        }

        // Writing the numbers starting from Row 0, Col 1++
        for (int startingPoint = 1; startingPoint < matrix.GetLength(1); startingPoint++)
        {
            indexA = 0;
            indexB = startingPoint;
            while (indexA < matrix.GetLength(1) && indexB < matrix.GetLength(1))
            {
                counter++;
                matrix[indexA, indexB] = counter;
                indexA++;
                indexB++;
            }
        }

        // Printing the result
        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                if (matrix[row, col] < 10)
                {
                    Console.Write(matrix[row, col] + "  ");
                }
                else
                {
                    Console.Write(matrix[row, col] + " ");
                }
            }

            Console.WriteLine();
        }
    }
}