using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public static class CollisionHandler
    {
        public static void HandleCollisions(Snake snake, List<Food> foodList, ConsoleRenderer renderer)
        {
            HandleEating(snake, foodList);
            HandleCollision(snake, renderer);
        }

        private static void HandleEating(Snake snake, List<Food> foodList)
        {
            foreach (Food food in foodList)
            {
                foreach (GameFieldCoords snakeElementPosition in snake.GetPosition())
                {
                    if (food.GetPosition()[0].Row == snakeElementPosition.Row
                        && food.GetPosition()[0].Col == snakeElementPosition.Col)
                    {
                        snake.GetBigger();
                        food.RespondToEating();
                    }
                }
            }
        }

        private static void HandleCollision(Snake snake, ConsoleRenderer renderer)
        {
            List<GameFieldCoords> snakeElements = new List<GameFieldCoords>();

            foreach (GameFieldCoords element in snake.GetPosition())
            {
                snakeElements.Add(element);
            }

            foreach (GameFieldCoords element in snakeElements)
            {
                if (element.Row >= renderer.GameFieldSize.Row || element.Row < 0
                    || element.Col >= renderer.GameFieldSize.Col || element.Col < 0)
                {
                    snake.IsDestroyed = true;
                }
            }

            for (int element = 0; element < snakeElements.Count - 1; element++)
            {
                if (snakeElements.Last().Row == snakeElements[element].Row
                    && snakeElements.Last().Col == snakeElements[element].Col)
                {
                    snake.IsDestroyed = true;
                }
            }
        }
    }
}