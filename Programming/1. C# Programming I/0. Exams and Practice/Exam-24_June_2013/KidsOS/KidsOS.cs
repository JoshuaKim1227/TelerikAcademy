using System;
using System.Collections.Generic;

class KidsOS
{
    static void Main()
    {
        int totalSectors = int.Parse(Console.ReadLine());
        int totalPartitions = int.Parse(Console.ReadLine());
        int numberOfWorkingOS = 0;
        int numberOfFailedOS = 0;

        List<int> listOfSectors = new List<int>();
        bool[] sectorMap = new bool[totalSectors];

        for (int i = 0; i < totalPartitions; i++)
        {
            string partition = Console.ReadLine();
            string[] parts = partition.Split(' ');

            foreach (string part in parts)
            {
                listOfSectors.Add(int.Parse(part));
            }
        }

        for (int sector = 1; sector < listOfSectors.Count; sector += 2)
        {
            for (int j = listOfSectors[sector - 1]; j <= listOfSectors[sector]; j++)
            {
                if (sectorMap[j] == false)
                {
                    sectorMap[j] = true;
                }
                else
                {
                    numberOfFailedOS++;
                    break;
                }
            }
        }

        numberOfWorkingOS = listOfSectors.Count / 2;

        numberOfWorkingOS -= numberOfFailedOS;

        Console.WriteLine(numberOfWorkingOS);
    }
}