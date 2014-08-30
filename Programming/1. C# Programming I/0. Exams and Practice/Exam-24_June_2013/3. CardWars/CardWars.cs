// 62/100 Points

using System;
using System.Collections.Generic;
using System.Numerics;

public class CardWars
{
    public static void Main()
    {
        // Getting the number of games
        int numberOfGames = int.Parse(Console.ReadLine());
        int cardsInSingleHand = 3;
        List<string> firstPlayerCards = new List<string>();
        List<string> secondPlayerCards = new List<string>();
        int player1CurrentScore = 0;
        int player2CurrentScore = 0;
        BigInteger player1TotalScore = 0;
        BigInteger player2TotalScore = 0;
        int player1WinsCount = 0;
        int player2WinsCount = 0;
        int startingPlace = 0;
        bool xCardP1 = false;
        bool xCardP2 = false;

        // Getting cards
        for (int game = 1; game <= numberOfGames; game++)
        {
            for (int card = 1; card <= cardsInSingleHand; card++)
            {
                firstPlayerCards.Add(Console.ReadLine());
            }

            for (int card = 1; card <= cardsInSingleHand; card++)
            {
                secondPlayerCards.Add(Console.ReadLine());
            }
        }

        // Playing games
        for (int game = 1; game <= numberOfGames; game++)
        {
            // Game
            for (int card = startingPlace; card < cardsInSingleHand + startingPlace; card++)
            {
                // If there is an X card
                if (firstPlayerCards[card] == "X"|| secondPlayerCards[card] == "X")
                {
                    if (firstPlayerCards[card] == "X" && secondPlayerCards[card] != "X")
                    {
                        xCardP1 = true;
                    }
                    if (firstPlayerCards[card] != "X" && secondPlayerCards[card] == "X")
                    {
                        xCardP2 = true;
                    }
                    if (firstPlayerCards[card] == "X" && secondPlayerCards[card] == "X")
                    {
                        xCardP1 = true;
                        xCardP2 = true;
                    }
                }
                // If there is an Y card
                else if (firstPlayerCards[card] == "Y"|| secondPlayerCards[card] == "Y")
                {
                    if (firstPlayerCards[card] == "Y" && secondPlayerCards[card] != "Y")
                    {
                        player1TotalScore -= 200;
                    }
                    if (firstPlayerCards[card] != "X" && secondPlayerCards[card] == "X")
                    {
                        player2TotalScore -= 200;
                    }
                    if (firstPlayerCards[card] == "X" && secondPlayerCards[card] == "X")
                    {
                        player1TotalScore -= 200;
                        player2TotalScore -= 200;
                    }
                }
                // If there is an Z card
                else if (firstPlayerCards[card] == "Y" || secondPlayerCards[card] == "Y")
                {
                    if (firstPlayerCards[card] == "Y" && secondPlayerCards[card] != "Y")
                    {
                        player1TotalScore *= 2;
                    }
                    if (firstPlayerCards[card] != "X" && secondPlayerCards[card] == "X")
                    {
                        player2TotalScore *= 2;
                    }
                    if (firstPlayerCards[card] == "X" && secondPlayerCards[card] == "X")
                    {
                        player1TotalScore *= 2;
                        player2TotalScore *= 2;
                    }
                }
                else
                {
                    player1CurrentScore += AddCardScore(firstPlayerCards[card]);
                    player2CurrentScore += AddCardScore(secondPlayerCards[card]);
                }
            }

            // X Card logic
            if (xCardP1 == true && xCardP2 == false)
            {
                Console.WriteLine("X card drawn! Player one wins the match!");
                return;
            }
            if (xCardP1 == false && xCardP2 == true)
            {
                Console.WriteLine("X card drawn! Player two wins the match!");
                return;
            }
            if (xCardP1 == true && xCardP2 == true)
            {
                player1TotalScore += 50;
                player2TotalScore += 50;
            }
            
            // Writing scores and wins
            if (player1CurrentScore > player2CurrentScore)
            {
                player1WinsCount += 1;
                player1TotalScore += player1CurrentScore;
            }
            else if (player1CurrentScore < player2CurrentScore)
            {
                player2WinsCount += 1;
                player2TotalScore += player2CurrentScore;
            }

            // Setting the counter to the next hand and resering the current scores
            startingPlace += 3;
            player1CurrentScore = 0;
            player2CurrentScore = 0;
        }

        if (player1TotalScore > player2TotalScore) // If player 1 wins
        {
            Console.WriteLine("First player wins!");
            Console.WriteLine("Score: {0}", player1TotalScore);
            Console.WriteLine("Games won: {0}", player1WinsCount);
        }
        else if (player1TotalScore < player2TotalScore) // If player 2 wins
        {
            Console.WriteLine("Second player wins!");
            Console.WriteLine("Score: {0}", player2TotalScore);
            Console.WriteLine("Games won: {0}", player2WinsCount);
        }
        else // If it's a tie
        {
            Console.WriteLine("It's a tie!");
            Console.WriteLine("Score: {0}", player1TotalScore);
        }
    }

    public static int AddCardScore(string card)
    {
        int score = 0;

        switch (card)
        {
            case "A": score = 1; break;
            case "2": score = 10; break;
            case "3": score = 9; break;
            case "4": score = 8; break;
            case "5": score = 7; break;
            case "6": score = 6; break;
            case "7": score = 5; break;
            case "8": score = 4; break;
            case "9": score = 3; break;
            case "10": score = 2; break;
            case "J": score = 11; break;
            case "Q": score = 12; break;
            case "K": score = 13; break;
            default: score = 0; break;
        }

        return score;
    }
}