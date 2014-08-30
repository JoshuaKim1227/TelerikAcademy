using System;
using System.Collections.Generic;

public class SpecialValue
{
    static void Main()
    {
        int[][] numSpace = GetInput();
        int result = FindBestPath(numSpace);

        Console.WriteLine(result);
    }

    static int[][] GetInput()
    {
        // Initializing data types
        int numberOfRows = int.Parse(Console.ReadLine());
        int[][] numberSpace = new int[numberOfRows][];
        int[] numers;

        // Splitting the input to rows
        for (int row = 0; row < numberOfRows; row++)
        {
            string rowStr = Console.ReadLine();
            string[] rowNums = rowStr.Split(',');

            numers = new int[rowNums.Length];

            // Splitting to columns
            for (int i = 0; i < rowNums.Length; i++)
            {
                numers[i] = int.Parse(rowNums[i]);
            }

            numberSpace[row] = numers;
        }

        return numberSpace;
    }

    static int FindBestPath(int[][] numSpace)
    {
        // Initializing data types
        int pathSteps = 1;
        int currentBestPath;
        int nextIndex;
        int row = 0;
        bool isVisited = false;
        int bestPath = int.MinValue;
        List<int> visitedRow = new List<int>();
        List<int> visitedCol = new List<int>();

        // Iterating through starting point
        for (int startingPoint = 0; startingPoint < numSpace[0].Length; startingPoint++)
        {
            nextIndex = startingPoint;

            // Finding a path
            while (true)
            {
                // If the number in the current position is less than 0
                if (numSpace[row][nextIndex] < 0)
                {
                    // Calculate the path
                    currentBestPath = numSpace[row][nextIndex] - (numSpace[row][nextIndex] * 2) + pathSteps;

                    // If current path is bigger than best path, change the value of best path
                    if (bestPath < currentBestPath)
                    {
                        bestPath = currentBestPath;
                    }

                    // Reset variables and break from the loop
                    visitedRow.Clear();
                    visitedCol.Clear();
                    pathSteps = 1;
                    row = 0;
                    break;
                }

                // If the number in the current position is 0 or bigger
                else
                {
                    // Assign the number in a nextIndex variable and add one path step
                    nextIndex = numSpace[row][nextIndex];
                    pathSteps++;

                    // If it's not the last row in the space of numbers - add 1 to row
                    if (row + 1 < numSpace.GetLength(0))
                    {
                        row++;
                    }

                    // If it's the last row in the space of numbers - reset row to 0
                    else
                    {
                        row = 0;
                    }

                    // Cheching if the next number is already visited
                    for (int counter = 0; counter < visitedCol.Count; counter++)
                    {
                        // If it is - set isVisited to True, reset variables and break from the loop
                        if (visitedCol[counter] == nextIndex && visitedRow[counter] == row)
                        {
                            isVisited = true;
                            visitedCol.Clear();
                            visitedRow.Clear();
                            pathSteps = 1;
                            row = 0;
                            break;
                        }
			        }

                    // If the number is not visited - add it to a list of visited numbers
                    if (!isVisited)
                    {
                        visitedCol.Add(nextIndex);
                        visitedRow.Add(row);
                    }
                    // If the number is visited - reset variables and break from the loop
                    else
                    {
                        visitedCol.Clear();
                        visitedRow.Clear();
                        pathSteps = 1;
                        row = 0;
                        break;
                    }
                }
            }
        }

        return bestPath;
    }
}

