using System;
using System.Collections.Generic;

class JoroTheRabbit
{
    static void Main()
    {
        int[] numbers = GetInput();

        int result = FindMaxVisitedPositions(numbers);

        Console.WriteLine(result);
    }

    static int[] GetInput()
    {
        string input = Console.ReadLine();

        string[] numChars = input.Split(',');

        int[] numbers = new int[numChars.Length];

        for (int num = 0; num < numChars.Length; num++)
        {
            numbers[num] = int.Parse(numChars[num]);
        }

        return numbers;
    }

    static int FindMaxVisitedPositions(int[] terrainNums)
    {
        int currentPosIndex = 0;
        int nextPosIndex = 0;
        int visitedPosCounter = 0;
        int bestRoute = 0;
        bool nextPosVisited = false;
        List<int> visitedPosList = new List<int>();

        for (int startingPosIndex = 0; startingPosIndex < terrainNums.Length; startingPosIndex++)
        {
            for (int stepSize = 1; stepSize < terrainNums.Length; stepSize++)
            {
                currentPosIndex = startingPosIndex;

                while (true)
                {
                    visitedPosCounter++;

                    nextPosIndex = currentPosIndex + stepSize;

                    if (nextPosIndex >= terrainNums.Length)
                    {
                        nextPosIndex = nextPosIndex - terrainNums.Length;
                    }

                    for (int position = 0; position < visitedPosList.Count; position++)
                    {
                        if (visitedPosList[position] == terrainNums[nextPosIndex])
                        {
                            nextPosVisited = true;
                        }
                    }

                    if (terrainNums[nextPosIndex] <= terrainNums[currentPosIndex] || nextPosVisited)
                    {
                        break;
                    }
                    else
                    {
                        currentPosIndex = nextPosIndex;
                    }
	            }

                if (bestRoute < visitedPosCounter)
                {
                    bestRoute = visitedPosCounter;
                }

                visitedPosCounter = 0;
            }
        }

        return bestRoute;
    }
}

