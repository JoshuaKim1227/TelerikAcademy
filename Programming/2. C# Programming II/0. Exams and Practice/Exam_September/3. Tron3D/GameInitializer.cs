using System;

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