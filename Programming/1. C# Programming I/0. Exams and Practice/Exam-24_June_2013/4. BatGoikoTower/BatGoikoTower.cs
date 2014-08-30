using System;
using System.Text;

public class BatGoikoTower
{
    public static void Main()
    {
        // Getting input and initializing variables
        int height = int.Parse(Console.ReadLine());
        StringBuilder towerBuilder = new StringBuilder();
        StringBuilder finishedTower = new StringBuilder();
        string leftPart = string.Empty;
        string rightPart = string.Empty;
        char[] arrayForReversing;
        int crossbeamPlaceCounter = 0;
        int crossbeamStep = 0;
        int row = 0;

        // Building the tower (left part)
        for (int i = height - 1; i >= 0; i--)
        {
            // Building the dots
            for (int j = 0; j < i; j++)
            {
                towerBuilder.Append(".");
            }

            // Building a wall
            towerBuilder.Append("/");

            // Checking if it's time to put a crossbeam
            if (crossbeamPlaceCounter == crossbeamStep)
            {
                for (int k = 0; k < row; k++)
                {
                    towerBuilder.Append("-");
                }

                crossbeamStep++;
                crossbeamPlaceCounter = 0;
            }
            else
            {
                for (int k = 0; k < row; k++)
                {
                    towerBuilder.Append(".");
                }
            }

            // Increase rows and the crossbeam counter
            row++;
            crossbeamPlaceCounter++;

            // Writing the builded Left part in a new string
            leftPart = towerBuilder.ToString();

            // Writing the Left part to an array of chars and reversing it
            arrayForReversing = leftPart.ToCharArray();
            Array.Reverse(arrayForReversing);

            // Writing the reversed Left part as a Right part
            foreach (char ch in arrayForReversing)
            {
                rightPart += ch;
            }

            // Replacing the walls of the Right part
            rightPart = rightPart.Replace('/', '\\');

            // Appending the builded line to a Finished tower
            finishedTower.Append(leftPart);
            finishedTower.Append(rightPart);
            finishedTower.Append("\n");

            // Reseting the Left and Right parts and the Tower builder
            leftPart = string.Empty;
            rightPart = string.Empty;
            towerBuilder.Clear();
        }

        Console.WriteLine(finishedTower);
    }
}