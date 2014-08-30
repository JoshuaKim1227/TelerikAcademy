using System;

public class SquareFinder
{
    public static void Main()
    {
        // Inizializing data types and getting user input
        Console.Write("Please enter Row size (Minimum 3): ");
        int rowSize = int.Parse(Console.ReadLine());
        Console.Write("Please enter Col size (Minimum 3): ");
        int colSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rowSize, colSize];
        int[] squareStartingPos = new int[2];

        int squareSize = 3;
        int currentSum = 0;
        int bestSum = int.MinValue;

        // Filling the matrix with random numbers
        Random rand = new Random();
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = rand.Next(1, 21);
            }
        }

        // Visualising the initial array
        Console.WriteLine("\nThe inizial matrix is:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] > 9)
                {
                    Console.Write(matrix[row, col] + "  ");
                }
                else
                {
                    Console.Write(matrix[row, col] + "   ");
                }
            }

            Console.WriteLine();
        }
 
        // Iterating through the array - generating starting point
        for (int row = 0; row <= matrix.GetLength(0) - squareSize; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - squareSize; col++)
            {
                // Finding the square with highest sum based on the starting point
                for (int squareIndexRow = row; squareIndexRow < row + squareSize; squareIndexRow++)
                {
                    for (int squareIndexCol = col; squareIndexCol < col + squareSize; squareIndexCol++)
                    {
                        currentSum = currentSum + matrix[squareIndexRow, squareIndexCol];
                        if (bestSum < currentSum)
                        {
                            bestSum = currentSum;
                            squareStartingPos[0] = squareIndexRow - squareSize + 1;
                            squareStartingPos[1] = squareIndexCol - squareSize + 1;
                        }
                    }
                }

                currentSum = 0;
            }
        }

        // Printing the result - the square and the highest sum
        Console.WriteLine("\nThe square with the highest sum is:");
        for (int i = squareStartingPos[0]; i < squareStartingPos[0] + squareSize; i++)
        {
            for (int j = squareStartingPos[1]; j < squareStartingPos[1] + squareSize; j++)
            {
                if (matrix[i, j] > 9)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                else
                {
                    Console.Write(matrix[i, j] + "  ");
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine("\nThe highest sum is: {0}", bestSum);
    }
}