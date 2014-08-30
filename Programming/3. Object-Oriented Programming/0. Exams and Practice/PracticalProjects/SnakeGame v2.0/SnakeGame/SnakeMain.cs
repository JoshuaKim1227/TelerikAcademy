using System.Collections.Generic;

namespace SnakeGame
{
    public class SnakeMain
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            // Game settings
            const int gameFieldHeight = 20;
            const int gameFieldWidth = 30;
            const int creatureLength = 5;
            const int foodAmountOnScreen = 1;

            // Initialize the game engine
            IUserController controller = new KeyboardController();
            IEngine gameEngine = new Engine(new ConsoleRenderer(new GameFieldCoords(gameFieldHeight, gameFieldWidth)),
                                            new Snake(creatureLength),
                                            new List<IEatable>(foodAmountOnScreen),
                                            new CollisionHandler(),
                                            new UsersManager(),
                                            controller);

            controller.OnUpPressed += (sender, eventInfo) =>
            {
                gameEngine.CreatureDirectionChange("up");
            };

            controller.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.CreatureDirectionChange("right");
            };

            controller.OnDownPressed += (sender, eventInfo) =>
            {
                gameEngine.CreatureDirectionChange("down");
            };

            controller.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.CreatureDirectionChange("left");
            };

            gameEngine.RunGame();
        }
    }
}