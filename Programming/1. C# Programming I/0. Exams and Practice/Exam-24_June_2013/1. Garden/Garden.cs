using System;

public class Garden
{
    public static void Main()
    {
        // Initializing 2D Array
        decimal[,] seedAmountAndArea = new decimal[6, 2];
        decimal[] costPerSeed = new decimal[6] { 0.5M, 0.4M, 0.25M, 0.6M, 0.3M, 0.4M };

        decimal costOfseeds = 0;
        decimal area = 0;
        decimal beansArea = 0;
        int availableArea = 250;

        // Getting input
        for (int i = 0; i < seedAmountAndArea.GetLength(0); i++)
        {
            for (int j = 0; j < seedAmountAndArea.GetLength(1); j++)
			{
                if (i != 5 || j != 1)
                {
                    seedAmountAndArea[i, j] = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
			}
        }

        // Calculating costs and area
        for (int item = 0; item < seedAmountAndArea.GetLength(0); item++)
        {
            costOfseeds += seedAmountAndArea[item, 0] * costPerSeed[item];
            area += seedAmountAndArea[item, 1];
        }


        Console.WriteLine("Total costs: {0:0.00}", costOfseeds);

        if (area > availableArea)
        {
            Console.WriteLine("Insufficient area");
        }
        else if (area == availableArea)
        {
            Console.WriteLine("No area for beans");
        }
        else
        {
            beansArea = availableArea - area;

            Console.WriteLine("Beans area: {0}", beansArea);
        }
    }
}