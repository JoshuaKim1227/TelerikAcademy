//using System;
//using System.Collections.Generic;
//using System.Text;

//class ThreeInOne
//{
//    static void Main()
//    {
//        int[] task1Nums = GetTask1Input();
//        int task1Result = SolveTask1(task1Nums);

//        int[] task2Sizes = GetTask2Sizes();
//        int task2Friends = GetTask2Friends();
//        int task2Result = SolveTask2(task2Sizes, task2Friends);

//        int[] coins = GetTask3Input();
//        int task3Result = SolveTask3(coins);

//        Console.WriteLine(task1Result);
//        Console.WriteLine(task2Result);
//        Console.WriteLine(task3Result);
//    }

//    static int[] GetTask1Input()
//    {
//        string input = Console.ReadLine();

//        string[] numbersStr = input.Split(',');

//        int[] numbers = new int[numbersStr.Length];

//        for (int index = 0; index < numbersStr.Length; index++)
//        {
//            numbers[index] = int.Parse(numbersStr[index]);
//        }

//        return numbers;
//    }

//    static int[] GetTask2Sizes()
//    {
//        string input = Console.ReadLine();

//        string[] numbersStr = input.Split(',');

//        int[] numbers = new int[numbersStr.Length];

//        for (int index = 0; index < numbersStr.Length; index++)
//        {
//            numbers[index] = int.Parse(numbersStr[index]);
//        }

//        return numbers;
//    }

//    static int GetTask2Friends()
//    {
//        int frineds = int.Parse(Console.ReadLine());

//        return frineds;
//    }

//    static int[] GetTask3Input()
//    {
//        string input = Console.ReadLine();

//        string[] numbersStr = input.Split(' ');

//        int[] numbers = new int[numbersStr.Length];

//        for (int index = 0; index < numbersStr.Length; index++)
//        {
//            numbers[index] = int.Parse(numbersStr[index]);
//        }

//        return numbers;
//    }

//    static int SolveTask1(int[] points)
//    {
//        int tempPoints;
//        int bestPoints = 0;
//        int bestPlayer = 0;

//        List<int> repetedNums = new List<int>();
 
//        for (int player = 0; player < points.Length; player++)
//        {
//            if (points[player] <= 21)
//            {
//                tempPoints = points[player];

//                if (bestPoints == tempPoints)
//                {
//                    repetedNums.Add(bestPoints);
//                }

//                if (bestPoints < tempPoints)
//                {
//                    bestPoints = tempPoints;
//                    bestPlayer = player;
//                }
//            }
//        }

//        foreach (int number in repetedNums)
//        {
//            if (points[bestPlayer] == number)
//            {
//                return -1;
//            }
//        }

//        return bestPlayer;
//    }

//    static int SolveTask2(int[] cake, int friends)
//    {
//        int me = 0;
//        int counter = 0;

//        Array.Sort(cake);
//        Array.Reverse(cake);

//        while (counter < cake.Length)
//        {
//            me += cake[counter];
//            counter += friends;
//            counter++;
//        }

//        return me;
//    }
    
//    static int SolveTask3(int[] coins)
//    {
//        // Initializing data types
//        int[] coinsInPocket = new int[3];
//        int[] coinsNeeded = new int[3];
//        bool[] enough = new bool[3];

//        int operationsCounter = 0;
//        int typeNeeded = 0;

//        int exchangeRateToLeft = 11;
//        int exchangeRateToRight = 9;

//        int neededBronze = 0;
//        int inPocketBronze = 0;

//        // Splitting the values to coinsInPocket and coinsNeeded
//        for (int index = 0; index < 3; index++)
//        {
//            coinsInPocket[index] = coins[index];
//            coinsNeeded[index] = coins[index + 3];
//        }

//        // Checking if there are enough coins by converting all to bronze
//        for (int typeOfCoins = 0; typeOfCoins < 3; typeOfCoins++)
//        {
//            if (typeOfCoins == 0)
//            {
//                inPocketBronze += coinsInPocket[typeOfCoins] * (exchangeRateToRight * exchangeRateToRight);

//                neededBronze += coinsNeeded[typeOfCoins] * (exchangeRateToRight * exchangeRateToRight);

//            }
//            else if (typeOfCoins == 1)
//            {
//                inPocketBronze += coinsInPocket[typeOfCoins] * exchangeRateToRight;

//                neededBronze += coinsNeeded[typeOfCoins] * exchangeRateToRight;
//            }
//            else
//            {
//                inPocketBronze += coinsInPocket[typeOfCoins];

//                neededBronze += coinsNeeded[typeOfCoins];
//            }
//        }

//        // Return -1 if coins are not enough
//        if (inPocketBronze < neededBronze)
//        {
//            return -1;
//        }

//        // Checking if there are enough coins from each type
//        for (int typeOfCoins = 0; typeOfCoins < 3; typeOfCoins++)
//        {
//            if (coinsInPocket[typeOfCoins] < coinsNeeded[typeOfCoins])
//            {
//                enough[typeOfCoins] = false;
//            }
//            else
//            {
//                enough[typeOfCoins] = true;
//            }
//        }

//        // Iterating to find which coins are not enough
//        while (typeNeeded < 3)
//        {
//            // Iterating to find which type of coins are enough to get from
//            for (int typeToGetFrom = 0; typeToGetFrom < 3; typeToGetFrom++)
//            {
//                // While there is not enough coins from the type that is needed
//                // and the coins that we get from are more than needed
//                while (!enough[typeNeeded] && coinsInPocket[typeToGetFrom] > coinsNeeded[typeToGetFrom])
//                {
//                    // If the type needed is more expensive than the coins we get from
//                    // and there are enough coins to exchange
//                    if (typeNeeded < typeToGetFrom && coinsInPocket[typeToGetFrom] >= exchangeRateToLeft)
//                    {
//                        coinsInPocket[typeToGetFrom - 1] += 1;
//                        coinsInPocket[typeToGetFrom] -= exchangeRateToLeft;

//                        operationsCounter++;

//                        // If we need gold and take bronze
//                        // and there are 11 silver coins already - break
//                        if (typeToGetFrom - typeNeeded == 2 && coinsInPocket[1] == 11)
//                        {
//                            break;
//                        }
//                    }

//                    // If the type needed is less expensive than the coins we get from
//                    // and there are enough coins to exchange
//                    if (typeNeeded > typeToGetFrom && coinsInPocket[typeToGetFrom] >= 1)
//                    {
//                        coinsInPocket[typeToGetFrom + 1] += exchangeRateToRight;
//                        coinsInPocket[typeToGetFrom] -= 1;

//                        operationsCounter++;

//                        // If we need gold and take bronze
//                        // and there are 9 silver coins already - break
//                        if (typeNeeded - typeToGetFrom == 2 && coinsInPocket[1] == 9)
//                        {
//                            break;
//                        }
//                    }

//                    // If current type of coins in pocket are enough set variable to true and break 
//                    if (coinsInPocket[typeNeeded] >= coinsNeeded[typeNeeded])
//                    {
//                        enough[typeNeeded] = true;
//                        break;
//                    }
//                }

//                // If current type of coins in pocket are enough change to the next type of coins and break
//                if (enough[typeNeeded])
//                {
//                    typeNeeded++;
//                    break;
//                }
//            }
//        }

//        return operationsCounter;
//    }
//}

