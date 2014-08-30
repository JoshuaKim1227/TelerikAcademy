using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SnakeGame
{
    public class Engine : IEngine
    {
        // Initializing data types
        private int foodAmount;
        private bool gameRunning = true;
        private decimal gameSpeed = 75;
        private string userName;
        private IRenderer renderer;
        private IUserController controller;
        private IHungryCreature creature;
        private List<IEatable> eatables;
        private ICollisionHandler collisionHandler;

        private Random foodPositionGenerator = new Random();

        // Engine constructor
        public Engine(IRenderer renderer, 
                      IHungryCreature creature, 
                      List<IEatable> eatables,
                      ICollisionHandler collisionHandler,
                      IUsersManager usersManager,
                      IUserController controller)
        {
            this.userName = usersManager.RequestUserName(renderer);
            this.foodAmount = eatables.Capacity;
            this.renderer = renderer;
            this.controller = controller;
            this.eatables = eatables;
            this.creature = creature;
            this.collisionHandler = collisionHandler;

            // Clear the console so the username won't be stuck on the scores screen
            renderer.ClearConsole();

            for (int counter = 0; counter < foodAmount; counter++)
            {
                this.AddFood();
            }
        }

        public void RunGame()
        {
            // Game loop
            while (this.gameRunning)
            {
                // Process user's input
                this.controller.ProcessInput();

                // Update creature's position and size
                this.creature.Update();

                // Handle collisions
                collisionHandler.HandleCollisions(this.creature, this.eatables, this.renderer);

                // Game over if creature is dead (stops the loop)
                if (this.creature.IsDestroyed)
                {
                    this.GameOver();
                    continue;
                }

                // Enqueue the creature for rendering
                this.renderer.EnqueueForRendering(this.creature);

                // If there is a eatable eated - add new one
                if (this.eatables.Any(food => food.IsEaten))
                {
                    this.AddFood();
                }

                // Remove eaten eatables
                this.eatables.RemoveAll(food => food.IsEaten);

                // Enqueue eatables for rendering
                for (int food = 0; food < this.eatables.Count; food++)
                {
                    this.renderer.EnqueueForRendering(this.eatables[food]);
                }

                // Render all objects
                this.renderer.RenderAll();

                if (this.gameSpeed > 1)
                {
                    this.gameSpeed -= 0.1M;
                }

                StatsCalculator.CalculateLevel();

                // Slow down the game loop so it is playable
                Thread.Sleep((int)this.gameSpeed);
            }

            // Sleep on Game over so the user won't accidently close the game screen
            Thread.Sleep(2000);
            Console.Write("Press any key to exit");

            while (Console.KeyAvailable)
            {
                Console.ReadKey(false);
            }

            Console.ReadKey();
        }

        public void CreatureDirectionChange(string newDirection)
        {
            this.creature.ChangeDirection(newDirection);
        }

        public void GameOver()
        {
            this.gameRunning = false;

            StatsCalculator.FinalizeScore(this.userName);

            this.renderer.RenderEndGame();
        }

        private void AddFood()
        {
            // Initialize data types
            int foodPlaceRow;
            int foodPlaceCol;
            bool invalidFoodPosition;

            // Update scores
            StatsCalculator.CalculateEatenFoodScore();
            StatsCalculator.CalculateEatenFoodCount();

            do
            {
                invalidFoodPosition = false;

                // Get random position for new eatable
                foodPlaceRow = this.foodPositionGenerator.Next(0, this.renderer.GameFieldSize.Row - 1);
                foodPlaceCol = this.foodPositionGenerator.Next(0, this.renderer.GameFieldSize.Col - 1);

                // Check if the position isn't occupied
                for (int element = 0; element < this.creature.GetPosition().Count; element++)
                {
                    if (foodPlaceRow == this.creature.GetPosition()[element].Row
                        && foodPlaceCol == this.creature.GetPosition()[element].Col)
                    {
                        invalidFoodPosition = true;
                    }
                }
            }
            // While the current postion is invalid, get new position
            while (invalidFoodPosition);

            // Add the eatable to the position
            this.eatables.Add(new Food(new GameFieldCoords(foodPlaceRow, foodPlaceCol)));
        }

        private void ProcessUserInput()
        {
            // Process Up direction
            this.controller.OnUpPressed += (sender, eventInfo) =>
            {
                creature.ChangeDirection("up");
            };

            // Process Right direction
            this.controller.OnRightPressed += (sender, eventInfo) =>
            {
                creature.ChangeDirection("right");
            };

            // Process Down direction
            this.controller.OnDownPressed += (sender, eventInfo) =>
            {
                creature.ChangeDirection("down");
            };

            // Process Left direction
            this.controller.OnLeftPressed += (sender, eventInfo) =>
            {
                creature.ChangeDirection("left");
            };
        }
    }
}