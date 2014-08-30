using System;

class DeckOfCards
{
    static void Main()
    {
        for (int rank = 1; rank <= 13; rank++)
        {
            for (int color = 1; color <= 4; color++)
            {
                switch (rank)
                {
                    case 1:
                        Console.Write("Ace of ");
                        break;
                    case 2:
                        Console.Write("2 of ");
                        break;
                    case 3:
                        Console.Write("3 of ");
                        break;
                    case 4:
                        Console.Write("4 of ");
                        break;
                    case 5:
                        Console.Write("5 of ");
                        break;
                    case 6:
                        Console.Write("6 of ");
                        break;
                    case 7:
                        Console.Write("7 of ");
                        break;
                    case 8:
                        Console.Write("8 of ");
                        break;
                    case 9:
                        Console.Write("9 of ");
                        break;
                    case 10:
                        Console.Write("10 of ");
                        break;
                    case 11:
                        Console.Write("Jack of ");
                        break;
                    case 12:
                        Console.Write("Queen of ");
                        break;
                    case 13:
                        Console.Write("King of ");
                        break;
                    default:
                        break;
                }
                switch (color)
                {
                    case 1:
                        Console.WriteLine("Clubs");
                        break;
                    case 2:
                        Console.WriteLine("Diamonds");
                        break;
                    case 3:
                        Console.WriteLine("Hearts");
                        break;
                    case 4:
                        Console.WriteLine("Spades");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

