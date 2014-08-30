using System;

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