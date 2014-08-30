namespace MinesweeperGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Minesweeper
    {
        public static void Main(string[] args)
        {
            const int Max = 35;

            char[,] gameField = InitializeGameField();
            char[,] mines = InitializeMines();

            int row = 0;
            int col = 0;
            int scoreCount = 0;

            bool startNewGame = true;
            bool beatTheGame = false;
            bool mineExploded = false;

            string command = string.Empty;

            List<Scores> players = new List<Scores>(6);

            do
            {
                if (startNewGame)
                {
                    Console.WriteLine("Lets play 'Minesweeper'. Test your luck finding the places without mines.");
                    Console.WriteLine("\nCommands: \n\n'top' shows the scores\n'restart' starts the game from the beginning\n'exit' quits the game");

                    RenderGameField(gameField);

                    startNewGame = false;
                }

                Console.Write("Enter numbers for row and col: ");

                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= gameField.GetLength(0) && col <= gameField.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        {
                            GetScores(players);
                            break;
                        }

                    case "restart":
                        {
                            gameField = InitializeGameField();
                            mines = InitializeMines();
                            RenderGameField(gameField);
                            mineExploded = false;
                            startNewGame = false;
                            break;
                        }

                    case "exit":
                        {
                            Console.WriteLine("Good Bye!");
                            break;
                        }

                    case "turn":
                        {
                            if (mines[row, col] != '*')
                            {
                                if (mines[row, col] == '-')
                                {
                                    SurroundingBombCount(gameField, mines, row, col);
                                    scoreCount++;
                                }

                                if (Max == scoreCount)
                                {
                                    beatTheGame = true;
                                }
                                else
                                {
                                    RenderGameField(gameField);
                                }
                            }
                            else
                            {
                                mineExploded = true;
                            }

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("\nError! Invalid Command.\n");
                            break;
                        }
                }

                if (mineExploded)
                {
                    RenderGameField(mines);

                    Console.Write("\nYou just exploded. Game Over! Your score - {0}. ", scoreCount);
                    Console.Write("Enter a User Name: ");

                    string userName = Console.ReadLine();

                    Scores scores = new Scores(userName, scoreCount);

                    if (players.Count < 5)
                    {
                        players.Add(scores);
                    }
                    else
                    {
                        for (int index = 0; index < players.Count; index++)
                        {
                            if (players[index].Score < scores.Score)
                            {
                                players.Insert(index, scores);
                                players.RemoveAt(players.Count - 1);
                                break;
                            }
                        }
                    }

                    players.Sort((Scores playerOne, Scores playerTwo) => playerTwo.Name.CompareTo(playerOne.Name));
                    players.Sort((Scores playerOne, Scores playerTwo) => playerTwo.Score.CompareTo(playerOne.Score));

                    GetScores(players);

                    gameField = InitializeGameField();
                    mines = InitializeMines();
                    scoreCount = 0;
                    mineExploded = false;
                    startNewGame = true;
                }

                if (beatTheGame)
                {
                    Console.WriteLine("\n Congratulations! You opened 35 places without dying.");

                    RenderGameField(mines);

                    Console.WriteLine("Please, enter your User Name: ");
                    string userName = Console.ReadLine();

                    Scores scores = new Scores(userName, scoreCount);

                    players.Add(scores);
                    GetScores(players);

                    gameField = InitializeGameField();
                    mines = InitializeMines();
                    scoreCount = 0;
                    beatTheGame = false;
                    startNewGame = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria - Refactored by Me!");
            Console.WriteLine("Good Bye.");
            Console.Read();
        }

        private static void GetScores(List<Scores> scores)
        {
            Console.WriteLine("\nScores:");

            if (scores.Count > 0)
            {
                for (int index = 0; index < scores.Count; index++)
                {
                    Console.WriteLine("{0}. {1} --> {2} places opened", index + 1, scores[index].Name, scores[index].Score);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Score board is empty!\n");
            }
        }

        private static void SurroundingBombCount(char[,] gameField, char[,] mines, int row, int col)
        {
            char minesCount = IndicateSurroundingMines(mines, row, col);
            mines[row, col] = minesCount;
            gameField[row, col] = minesCount;
        }

        private static void RenderGameField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);

                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0} ", board[row, col]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] InitializeGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardColumns; col++)
                {
                    board[row, col] = '?';
                }
            }

            return board;
        }

        private static char[,] InitializeMines()
        {
            int rows = 5;
            int cols = 10;

            char[,] gameField = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    gameField[row, col] = '-';
                }
            }

            List<int> minePlaces = new List<int>();

            while (minePlaces.Count < 15)
            {
                Random randomGenerator = new Random();
                int minePlace = randomGenerator.Next(50);

                if (!minePlaces.Contains(minePlace))
                {
                    minePlaces.Add(minePlace);
                }
            }

            foreach (int minePlace in minePlaces)
            {
                int col = minePlace / cols;
                int row = minePlace % cols;

                if (row == 0 && minePlace != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }

                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static void CountMineIndicators(char[,] gameField)
        {
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (gameField[row, col] != '*')
                    {
                        char currentMinesIndicatorNumber = IndicateSurroundingMines(gameField, row, col);
                        gameField[row, col] = currentMinesIndicatorNumber;
                    }
                }
            }
        }

        private static char IndicateSurroundingMines(char[,] gameField, int row, int col)
        {
            int minesCount = 0;
            int rows = gameField.GetLength(0);
            int cols = gameField.GetLength(1);

            if (row - 1 >= 0)
            {
                if (gameField[row - 1, col] == '*')
                {
                    minesCount++;
                }
            }

            if (row + 1 < rows)
            {
                if (gameField[row + 1, col] == '*')
                {
                    minesCount++;
                }
            }

            if (col - 1 >= 0)
            {
                if (gameField[row, col - 1] == '*')
                {
                    minesCount++;
                }
            }

            if (col + 1 < cols)
            {
                if (gameField[row, col + 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (gameField[row - 1, col - 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (gameField[row - 1, col + 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (gameField[row + 1, col - 1] == '*')
                {
                    minesCount++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (gameField[row + 1, col + 1] == '*')
                {
                    minesCount++;
                }
            }

            return char.Parse(minesCount.ToString());
        }
    }
}