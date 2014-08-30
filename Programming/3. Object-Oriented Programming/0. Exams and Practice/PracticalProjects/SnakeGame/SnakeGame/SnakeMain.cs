using System;

namespace SnakeGame
{
    public class SnakeMain
    {
        public static void Main()
        {
            ConsoleRenderer renderer = new ConsoleRenderer(new GameFieldCoords(20, 40));
            IUserController keyboard = new KeyboardController();

            Engine gameEngine = new Engine(renderer, keyboard, 5, 1);

            keyboard.OnUpPressed += (sender, eventInfo) =>
            {
                gameEngine.SnakeDirectionChange("up");
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.SnakeDirectionChange("right");
            };

            keyboard.OnDownPressed += (sender, eventInfo) =>
            {
                gameEngine.SnakeDirectionChange("down");
            };

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.SnakeDirectionChange("left");
            };

            gameEngine.RunGame();
        }
    }
}