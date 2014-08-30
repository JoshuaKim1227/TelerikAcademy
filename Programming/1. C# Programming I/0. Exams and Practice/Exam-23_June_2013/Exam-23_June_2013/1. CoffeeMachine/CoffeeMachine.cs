using System;

public class CoffeeMachine
{
    public static void Main()
    {
        // Getting input
        decimal[] machineCoins = new decimal[5];
        decimal change = 0;

        for (int coinType = machineCoins.Length - 1; coinType >= 0; coinType--)
        {
            machineCoins[coinType] = int.Parse(Console.ReadLine());
        }

        decimal userCoins = decimal.Parse(Console.ReadLine());
        decimal drinkPrice = decimal.Parse(Console.ReadLine());

        // Calculate needed change
        change = userCoins - drinkPrice;

        // Give change
        if (change >= 0)
        {
            while (change >= 1 && machineCoins[0] >= 1)
            {
                machineCoins[0]--;
                change--;
            }

            while (change >= 0.50M && machineCoins[1] >= 0.50M)
            {
                machineCoins[1]--;
                change -= 0.50M;
            }

            while (change >= 0.20M && machineCoins[2] >= 0.20M)
            {
                machineCoins[2]--;
                change -= 0.20M;
            }

            while (change >= 0.10M && machineCoins[3] >= 0.10M)
            {
                machineCoins[3]--;
                change -= 0.10M;
            }

            while (change >= 0.05M && machineCoins[4] >= 0.05M)
            {
                machineCoins[4]--;
                change -= 0.05M;
            }

            // Calculate the amount of money left in tray
            if (change <= 0)
            {
                decimal coinsLeft = 0;

                while (machineCoins[0] > 0)
                {
                    coinsLeft += 1;
                    machineCoins[0]--;
                }

                while (machineCoins[1] > 0)
                {
                    coinsLeft += 0.50M;
                    machineCoins[1]--;
                }

                while (machineCoins[2] > 0)
                {
                    coinsLeft += 0.20M;
                    machineCoins[2]--;
                }

                while (machineCoins[3] > 0)
                {
                    coinsLeft += 0.10M;
                    machineCoins[3]--;
                }

                while (machineCoins[4] > 0)
                {
                    coinsLeft += 0.05M;
                    machineCoins[4]--;
                }

                // Write the result
                Console.WriteLine("Yes {0:0.00}", coinsLeft);
            }
            else // Not enough money to give change
            {
                Console.WriteLine("No {0:0.00}", change);
            }
        }
        else // Not enough money for a drink
        {
            Console.WriteLine("More {0:0.00}", drinkPrice - userCoins);
        }
    }
}