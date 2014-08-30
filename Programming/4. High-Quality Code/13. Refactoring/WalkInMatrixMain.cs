using System;

public struct MatrixCoords
{
    public int Row;
    public int Col;
}

public class WalkInMatrix
{
    private static MatrixCoords currentPosition = new MatrixCoords();
    private static int currentNumber;

    private static int[] directionRow;
    private static int[] directionCol;

    private static int[,] matrix;

    public static void Main()
    {
        int matrixSize = GetInput();
        string result = WalkThroughMatrix(matrixSize);
        Console.WriteLine(result);
    }

    public static string WalkThroughMatrix(int matrixSize)
    {
        matrix = new int[matrixSize, matrixSize];
        currentPosition.Row = 0;
        currentPosition.Col = 0;
        currentNumber = 1;

        Walk(currentPosition, matrixSize);
        currentPosition = FindNewStartPosition(matrix);

        if (currentPosition.Row != 0 && currentPosition.Col != 0)
        {
            currentNumber++;
            Walk(currentPosition, matrixSize);
        }

        return ConstructResult(matrixSize);
    }

    private static void Walk(MatrixCoords currentPosition, int matrixSize)
    {
        bool neighbouringCellEmpty = true;
        MatrixCoords direction = new MatrixCoords();
        direction.Row = 1;
        direction.Col = 1;

        while (true)
        {
            matrix[currentPosition.Row, currentPosition.Col] = currentNumber;
            neighbouringCellEmpty = CheckNeighbouringCells(currentPosition);

            if (neighbouringCellEmpty)
            {
                while (currentPosition.Row + direction.Row >= matrixSize || currentPosition.Row + direction.Row < 0 || 
                    currentPosition.Col + direction.Col >= matrixSize || currentPosition.Col + direction.Col < 0 || 
                    matrix[currentPosition.Row + direction.Row, currentPosition.Col + direction.Col] != 0)
                {
                    direction = ChangeDirection(direction);
                }
            }
            else
            {
                break;
            }

            currentPosition.Row += direction.Row;
            currentPosition.Col += direction.Col;
            currentNumber++;
        }
    }

    private static MatrixCoords ChangeDirection(MatrixCoords currentDirection)
    {
        InitializeDirectionArrays();

        int direction = 0;

        for (int directionsCounter = 0; directionsCounter < 8; directionsCounter++)
        {
            if (directionRow[directionsCounter] == currentDirection.Row && directionCol[directionsCounter] == currentDirection.Col)
            {
                direction = directionsCounter;
                break;
            }
        }

        if (direction != 7)
        {
            currentDirection.Row = directionRow[direction + 1];
            currentDirection.Col = directionCol[direction + 1];
        }
        else
        {
            currentDirection.Row = directionRow[0];
            currentDirection.Col = directionCol[0];
        }

        return currentDirection;
    }

    private static bool CheckNeighbouringCells(MatrixCoords currentPosition)
    {
        InitializeDirectionArrays();

        for (int direction = 0; direction < 8; direction++)
        {
            if (currentPosition.Row + directionRow[direction] >= matrix.GetLength(0) || currentPosition.Row + directionRow[direction] < 0)
            {
                directionRow[direction] = 0;
            }

            if (currentPosition.Col + directionCol[direction] >= matrix.GetLength(0) || currentPosition.Col + directionCol[direction] < 0)
            {
                directionCol[direction] = 0;
            }
        }

        for (int direction = 0; direction < 8; direction++)
        {
            if (matrix[currentPosition.Row + directionRow[direction], currentPosition.Col + directionCol[direction]] == 0)
            {
                return true;
            }
        }

        return false;
    }

    private static MatrixCoords FindNewStartPosition(int[,] matrix)
    {
        MatrixCoords availableCellPosition = new MatrixCoords();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                if (matrix[row, col] == 0)
                {
                    availableCellPosition.Row = row;
                    availableCellPosition.Col = col;

                    return availableCellPosition;
                }
            }
        }

        return availableCellPosition;
    }

    private static void InitializeDirectionArrays()
    {
        directionRow = new int[8] { 1, 1, 1, 0, -1, -1, -1, 0 };
        directionCol = new int[8] { 1, 0, -1, -1, -1, 0, 1, 1 };
    }

    private static int GetInput()
    {
        Console.Write("Enter a positive number: ");
        string input = Console.ReadLine();
        int matrixSize;

        while (!int.TryParse(input, out matrixSize) || (matrixSize < 0 || matrixSize > 100))
        {
            Console.WriteLine("You haven't entered positive number between 0 and 100.");
            Console.Write("Enter a positive number: ");
            input = Console.ReadLine();
        }

        return matrixSize;
    }

    private static string ConstructResult(int matrixSize)
    {
        string MatrixOutput = string.Empty;

        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                MatrixOutput += String.Format("{0,3}", matrix[row, col]);
            }

            MatrixOutput += "\n";
        }

        return MatrixOutput;
    }
}