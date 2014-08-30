using System;
using System.IO;
using System.Text;

public class MatrixAreaInFile
{
    public static void Main()
    {
        string strFromFile = ReadFile("file.txt");
        int[,] matrix = ConvertToIntMatrix(strFromFile);
        int finalResult = FindMaxSumArea(matrix);
        WriteToFile(finalResult, "result.txt");
    }

    public static string ReadFile(string fileName)
    {
        string outputStr;

        StreamReader reader = new StreamReader(fileName);

        using (reader)
        {
            outputStr = reader.ReadToEnd();
        }

        return outputStr;
    }

    public static int[,] ConvertToIntMatrix(string strToConvert)
    {
        // Initializing data types
        int matrixSize;
        string[] splittedToCols;
        string[] splittedToRows;
        string[,] strMatrix;
        int[,] intMatrix;

        // Remove the '\r'
        strToConvert = strToConvert.Replace("\r", string.Empty);

        // Split to rows by '\n'
        splittedToRows = strToConvert.Split('\n');

        // Parsing the size of the matrix
        matrixSize = int.Parse(splittedToRows[0]);

        // Initializing the matrixes
        strMatrix = new string[matrixSize, matrixSize];
        intMatrix = new int[matrixSize, matrixSize];

        // Iterating through the strings 
        // and writing to the final string matrix.
        // Also parsing the result to an int matrix.
        for (int rows = 1; rows <= matrixSize; rows++)
        {
            for (int cols = 0; cols < matrixSize; cols++)
            {
                splittedToCols = splittedToRows[rows].Split(' ');
                strMatrix[rows - 1, cols] = splittedToCols[cols];
                intMatrix[rows - 1, cols] = int.Parse(strMatrix[rows - 1, cols]);
            }
        }

        return intMatrix;
    }

    public static int FindMaxSumArea(int[,] matrixToProcess)
    {
        // Initializing tada types
        int areaSize = 2;
        int tempResult = 0;
        int bestResult = int.MinValue;

        // Starting position
        for (int row = 0; row < matrixToProcess.GetLength(0) - areaSize + 1; row++)
        {
            for (int col = 0; col < matrixToProcess.GetLength(1) - areaSize + 1; col++)
            {
                // Sum the numbers in area
                for (int areaRow = row; areaRow < row + areaSize; areaRow++)
                {
                    for (int areaCol = col; areaCol < col + areaSize; areaCol++)
                    {
                        tempResult = tempResult + matrixToProcess[areaRow, areaCol];
                    }
                }

                // Find the maximal sum
                if (bestResult < tempResult)
                {
                    bestResult = tempResult;
                }

                tempResult = 0;
            }
        }

        return bestResult;
    }

    public static void WriteToFile(int numberToWrite, string fileName)
    {
        StreamWriter writer = new StreamWriter(fileName);

        using (writer)
        {
            writer.WriteLine(numberToWrite);
        }

        Console.WriteLine("Result successfully writed to {0}.", fileName);
    }
}