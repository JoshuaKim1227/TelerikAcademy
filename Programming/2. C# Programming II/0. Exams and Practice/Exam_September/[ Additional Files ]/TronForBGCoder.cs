using System;
using System.Text;

public enum Direction
{
    East = 0,
    South = 1,
    West = 2,
    North = 3
}

public class GameEngine
{
    private bool[,] gameField;
    private Position[] playersPosition;
    private Direction[] playersDirection;

    private string[] playersMoveList;

    public string FinalResult { get; private set; }

    public int StartToEndDistance { get; private set; }

    public GameEngine(bool[,] gameField, Position[] playersPosition, string[] playersMoveList)
    {
        this.gameField = gameField;
        this.playersPosition = playersPosition;
        this.playersDirection = new Direction[2];
        this.playersMoveList = new string[2];

        this.playersDirection[0] = Direction.East;
        this.playersDirection[1] = Direction.West;

        this.playersMoveList[0] = playersMoveList[0];
        this.playersMoveList[1] = playersMoveList[1];
    }

    public void RunGame()
    {
        int playersCount = 2;
        bool[] alreadyMoved = new bool[2];
        bool playerOneCrashed = false;
        bool playerTwoCrashed = false;
        Position redPlayerStartPos = this.playersPosition[0];

        StringBuilder builder = new StringBuilder();
        for (int move = 0; move < playersMoveList[0].Length; move++)
        {
            for (int player = 0; player < playersCount; player++)
            {
                if (alreadyMoved[player] == true)
                {
                    alreadyMoved[player] = false;
                    builder.Append(this.playersMoveList[player][move]);
                    continue;
                }

                if (this.playersMoveList[player][move] == 'L')
                {
                    ChangeDirectionLeft(player);
                    MovePlayer(player);
                    alreadyMoved[player] = true;
                }
                else if (this.playersMoveList[player][move] == 'R')
                {
                    ChangeDirectionRight(player);
                    MovePlayer(player);
                    alreadyMoved[player] = true;
                }
                else if (this.playersMoveList[player][move] == 'M')
                {
                    MovePlayer(player);
                }

                if (this.gameField[this.playersPosition[player].Row, this.playersPosition[player].Col] == false)
                {
                    MarkPositionAsVisited(player);
                }
                else
                {
                    if (player == 0)
                    {
                        playerOneCrashed = true;
                    }
                    if (player == 1)
                    {
                        playerTwoCrashed = true;
                    }
                }

                builder.Append(this.playersMoveList[player][move]);
            }

            if (playerOneCrashed && playerTwoCrashed)
            {
                break;
            }
        }

        this.StartToEndDistance = FindStartToEndDistance(redPlayerStartPos, playersPosition[0]);
        this.FinalResult = CheckForWinner(playerOneCrashed, playerTwoCrashed);
    }

    private int FindStartToEndDistance(Position redPlayerStartPos, Position redPlayerEndPos)
    {
        int distanceCouter = -1;

        if (redPlayerStartPos.Row > redPlayerEndPos.Row)
        {
            while (redPlayerStartPos.Row != redPlayerEndPos.Row)
            {
                redPlayerEndPos.Row++;
                distanceCouter++;
            }
        }
        else if (redPlayerStartPos.Row < redPlayerEndPos.Row)
        {
            while (redPlayerStartPos.Row != redPlayerEndPos.Row)
            {
                redPlayerEndPos.Row--;
                distanceCouter++;
            }
        }

        if (redPlayerStartPos.Col > redPlayerEndPos.Col)
        {
            while (redPlayerStartPos.Col != redPlayerEndPos.Col)
            {
                redPlayerEndPos.Col++;
                distanceCouter++;
            }
        }
        else if (redPlayerStartPos.Col < redPlayerEndPos.Col)
        {
            while (redPlayerStartPos.Col != redPlayerEndPos.Col)
            {
                redPlayerEndPos.Col--;
                distanceCouter++;
            }
        }

        return distanceCouter;
    }

    private static string CheckForWinner(bool playerOneCrashed, bool playerTwoCrashed)
    {
        if (playerOneCrashed && playerTwoCrashed)
        {
            return "DRAW";
        }
        else if (playerOneCrashed)
        {
            return "BLUE";
        }
        else if (playerTwoCrashed)
        {
            return "RED";
        }
        else
        {
            return "DRAW";
        }
    }

    private void ChangeDirectionRight(int player)
    {
        if (this.playersDirection[player] < Direction.North)
        {
            this.playersDirection[player] += 1;
        }
        else
        {
            this.playersDirection[player] = Direction.East;
        }
    }

    private void ChangeDirectionLeft(int player)
    {
        if (this.playersDirection[player] > 0)
        {
            this.playersDirection[player] -= 1;
        }
        else
        {
            this.playersDirection[player] = Direction.North;
        }
    }

    private void MovePlayer(int player)
    {
        if (this.playersDirection[player] == Direction.East)
        {
            this.playersPosition[player].Col++;
        }
        else if (this.playersDirection[player] == Direction.South)
        {
            this.playersPosition[player].Row++;
        }
        else if (this.playersDirection[player] == Direction.West)
        {
            this.playersPosition[player].Col--;
        }
        else if (this.playersDirection[player] == Direction.North)
        {
            this.playersPosition[player].Row--;
        }
    }

    private void MarkPositionAsVisited(int player)
    {
        if (this.playersPosition[player].Row < 0)
        {
            this.playersPosition[player].Row = this.gameField.GetLength(0) - 1;
        }
        else if (this.playersPosition[player].Row > this.gameField.GetLength(0) - 1)
        {
            this.playersPosition[player].Row = 0;
        }

        if (this.playersPosition[player].Col < 0)
        {
            this.playersPosition[player].Col = this.gameField.GetLength(1) - 1;
        }
        else if (this.playersPosition[player].Col > this.gameField.GetLength(1) - 1)
        {
            this.playersPosition[player].Col = 0;
        }

        this.gameField[this.playersPosition[player].Row, this.playersPosition[player].Col] = true;
    }
}
public class GameInitializer
{
    private int dimensionX;
    private int dimensionY;
    private int dimensionZ;

    public GameInitializer()
    {
        PlayersPosition = new Position[2];
        playersMoveList = new string[2];
    }

    public bool[,] GameField { get; private set; }

    public Position[] PlayersPosition { get; set; }

    public string[] playersMoveList { get; private set; }

    public void InitializeGame()
    {
        this.ReadInput();
        this.InitializeGrid();
        this.InitializePlayersOnStartPositions();
    }

    private void ReadInput()
    {
        string dimensions = Console.ReadLine();

        playersMoveList[0] = Console.ReadLine();
        playersMoveList[1] = Console.ReadLine();

        string[] dimensionsSplitted = dimensions.Split(' ');

        dimensionX = int.Parse(dimensionsSplitted[0]) + 1;
        dimensionY = int.Parse(dimensionsSplitted[1]);
        dimensionZ = int.Parse(dimensionsSplitted[2]);
    }

    private void InitializeGrid()
    {
        this.GameField = new bool[dimensionX, (dimensionY * 2 + dimensionZ * 2)];
    }

    private void InitializePlayersOnStartPositions()
    {
        PlayersPosition[0].Row = dimensionX / 2;
        PlayersPosition[0].Col = dimensionY / 2;

        PlayersPosition[1].Row = dimensionX / 2;
        PlayersPosition[1].Col = PlayersPosition[0].Col + (GameField.GetLength(1) / 2);
        //PlayersPosition[1].Col = this.GameField.GetLength(1) - dimensionZ - (dimensionY / 2);
        //PlayersPosition[1].Col = (dimensionY / 2) + dimensionY + dimensionZ + 3;

        this.GameField[PlayersPosition[0].Row, PlayersPosition[0].Col] = true;
        this.GameField[PlayersPosition[1].Row, PlayersPosition[1].Col] = true;
    }
}

public struct Position
{
    public int Row;
    public int Col;
}
public class Tron3DMain
{
    public static void Main()
    {
        GameInitializer initializer = new GameInitializer();
        initializer.InitializeGame();

        GameEngine engine = new GameEngine(initializer.GameField, initializer.PlayersPosition, initializer.playersMoveList);
        engine.RunGame();

        Console.WriteLine(engine.FinalResult);
        Console.WriteLine(engine.StartToEndDistance);
    }
}