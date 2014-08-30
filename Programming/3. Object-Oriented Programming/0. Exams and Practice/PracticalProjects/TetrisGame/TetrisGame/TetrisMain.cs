namespace TetrisGame
{
    using System;
    using System.Threading;

    public class TetrisMain
    {
        public static void Main()
        {
            KeyboardController keyboard = new KeyboardController();
            Engine gameEngine = new Engine(keyboard);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MoveTetriminoLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MoveTetriminoRight();
            };

            gameEngine.RunGame();
        }
    }
}