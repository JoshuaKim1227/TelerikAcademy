using System;

public struct Point
{
    public int X;
    public int Y;
    public int Z;
}

public enum Directions
{
    Right = 0,
    Down = 1,
    Left = 2,
    Up = 3
}

public class Tron3DMain
{
    public static Point dimension = new Point();
    public static Point playerOnePos = new Point();
    public static Point playerTwoPos = new Point();

    public static Point playerOneMoveDirection = new Point();
    public static Point playerTwoMoveDirection = new Point();

    public static Point[] directions = new Point[4];

    public static Directions direction = new Directions();

    public static string firstPlayerMoves;
    public static string secondPlayerMoves;
    public static bool[,] grid;

    public static void Main()
    {
        GetInput();
        InitializeGrid();
        InitializePlayersOnStartPositions();
    }

    public static void GetInput()
    {
        string dimensions = Console.ReadLine();
        firstPlayerMoves = Console.ReadLine();
        secondPlayerMoves = Console.ReadLine();

        string[] dimensionsSplitted = dimensions.Split(' ');
        dimension.X = int.Parse(dimensionsSplitted[0]) + 1;
        dimension.Y = int.Parse(dimensionsSplitted[1]);
        dimension.Z = int.Parse(dimensionsSplitted[2]);
    }

    public static void InitializeGrid()
    {
        grid = new bool[dimension.X, (dimension.Y * 2 + dimension.Z * 2)];
    }

    public static void InitializePlayersOnStartPositions()
    {
        playerOnePos.X = dimension.X / 2;
        playerOnePos.Y = dimension.Y / 2;

        playerTwoPos.X = dimension.X / 2;
        playerTwoPos.Y = (dimension.Y / 2) + dimension.Y + dimension.Z;

        grid[playerOnePos.X, playerOnePos.Y] = true;
        grid[playerTwoPos.X, playerTwoPos.Y] = true;
    }

    public static void MovePlayers()
    {
    }

    public static void InitializeDirections()
    {
        directions[0].X = 0;
        directions[0].Y = 1;

        directions[1].X = -1;
        directions[1].Y = 0;

        directions[2].X = 0;
        directions[2].Y = -1;

        directions[3].X = 1;
        directions[3].Y = 0;
    }

    public static void ChangeDirection(char letter, Point currentDirection)
    {
        if (letter == 'L')
        {
        }
    }
}