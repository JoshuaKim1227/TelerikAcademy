using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SnakeGame
{
    public class Engine
    {
        private ConsoleRenderer renderer;
        private IUserController controller;
        private int snakeLength;
        private int foodAmount;
        private bool gameRunning = true;
        private decimal gameSpeed = 75;
        private string userName;

        private UsersManager usersManager = new UsersManager();
        private Random foodPositionGenerator = new Random();

        private Snake snake;
        private List<Food> foodList;

        public Engine(ConsoleRenderer renderer, IUserController controller, int snakeLength, int foodAmount)
        {
            this.userName = this.usersManager.RequestUserName(renderer);

            this.renderer = renderer;
            this.controller = controller;
            this.snakeLength = snakeLength;
            this.foodAmount = foodAmount;

            this.foodList = new List<Food>(foodAmount);
            this.snake = new Snake(snakeLength);

            for (int counter = 0; counter < foodAmount; counter++)
            {
                this.AddFood();
            }
        }

        public void RunGame()
        {
            while (this.gameRunning)
            {
                this.controller.ProcessInput();

                this.snake.Update();

                CollisionHandler.HandleCollisions(this.snake, this.foodList, this.renderer);

                if (this.snake.IsDestroyed)
                {
                    this.GameOver();
                    continue;
                }

                this.renderer.EnqueueForRendering(this.snake);

                if (this.foodList.Any(food => food.IsEaten))
                {
                    this.AddFood();
                }

                this.foodList.RemoveAll(food => food.IsEaten);

                for (int food = 0; food < this.foodList.Count; food++)
                {
                    this.renderer.EnqueueForRendering(this.foodList[food]);
                }

                this.renderer.RenderAll();

                if (this.gameSpeed > 1)
                {
                    this.gameSpeed -= 0.1M;
                }

                InfoCalculator.CalculateLevel();

                Thread.Sleep((int)this.gameSpeed);
            }

            Thread.Sleep(3000);
            Console.Write("Press any key to exit");

            while (Console.KeyAvailable)
            {
                Console.ReadKey(false);
            }

            Console.ReadKey();
        }

        public void SnakeDirectionChange(string newDirection)
        {
            this.snake.ChangeDirection(newDirection);
        }

        public void GameOver()
        {
            this.gameRunning = false;

            InfoCalculator.FinalizeScore(this.userName);

            this.renderer.EndGame();
        }

        private void AddFood()
        {
            int foodPlaceRow;
            int foodPlaceCol;
            bool invalidFoodPosition;

            InfoCalculator.CalculateEatenFoodScore();
            InfoCalculator.CalculateEatenFoodCount();

            do
            {
                invalidFoodPosition = false;

                foodPlaceRow = this.foodPositionGenerator.Next(0, this.renderer.GameFieldSize.Row - 1);
                foodPlaceCol = this.foodPositionGenerator.Next(0, this.renderer.GameFieldSize.Col - 1);

                for (int element = 0; element < this.snake.GetPosition().Count; element++)
                {
                    if (foodPlaceRow == this.snake.GetPosition()[element].Row
                        && foodPlaceCol == this.snake.GetPosition()[element].Col)
                    {
                        invalidFoodPosition = true;
                    }
                }
            } 
            while (invalidFoodPosition);

            this.foodList.Add(new Food(new GameFieldCoords(foodPlaceRow, foodPlaceCol)));
        }

        private void ProcessUserInput()
        {
            this.controller.OnUpPressed += (sender, eventInfo) =>
            {
                snake.ChangeDirection("up");
            };

            this.controller.OnRightPressed += (sender, eventInfo) =>
            {
                snake.ChangeDirection("right");
            };

            this.controller.OnDownPressed += (sender, eventInfo) =>
            {
                snake.ChangeDirection("down");
            };

            this.controller.OnLeftPressed += (sender, eventInfo) =>
            {
                snake.ChangeDirection("left");
            };
        }
    }
}