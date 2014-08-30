using System.Collections.Generic;
using System.Linq;

namespace SnakeGame
{
    public class Snake : IHungryCreature
    {
        // Initialize data types
        private readonly char renderingSymbol = '*';

        private Queue<GameFieldCoords> snakeElements = new Queue<GameFieldCoords>();
        private KeyboardController keyboard = new KeyboardController();

        private string currentDirection = "up";
        private bool isDestroyed = false;
        private bool isGettingBigger = false;

        // Snake's constructor
        public Snake(int length)
        {
            this.InitializeSnake(length);
        }

        public char RenderingSymbol
        {
            get
            {
                return this.renderingSymbol;
            }
        }

        public bool IsDestroyed
        {
            get
            {
                return this.isDestroyed;
            }

            set
            {
                this.isDestroyed = value;
            }
        }

        public void Update()
        {
            // Get new head position
            GameFieldCoords newHeadPosition;

            if (this.currentDirection == "up")
            {
                newHeadPosition = new GameFieldCoords(this.snakeElements.Last().Row - 1, this.snakeElements.Last().Col);
            }
            else if (this.currentDirection == "right")
            {
                newHeadPosition = new GameFieldCoords(this.snakeElements.Last().Row, this.snakeElements.Last().Col + 1);
            }
            else if (this.currentDirection == "down")
            {
                newHeadPosition = new GameFieldCoords(this.snakeElements.Last().Row + 1, this.snakeElements.Last().Col);
            }
            else
            {
                newHeadPosition = new GameFieldCoords(this.snakeElements.Last().Row, this.snakeElements.Last().Col - 1); 
            }

            // Add new snake element to the new position
            this.snakeElements.Enqueue(newHeadPosition);

            if (!this.isGettingBigger)
            {
                // Remove the last element if the snake is not getting bigger
                this.snakeElements.Dequeue();
            }

            this.isGettingBigger = false;
        }

        public void ChangeDirection(string newDirection)
        {
            // Change snake's moving direction
            if (!(this.currentDirection == "up" && newDirection == "down")
                && !(this.currentDirection == "right" && newDirection == "left")
                && !(this.currentDirection == "down" && newDirection == "up")
                && !(this.currentDirection == "left" && newDirection == "right"))
            {
                this.currentDirection = newDirection;
            }
        }

        public void GetBigger()
        {
            this.isGettingBigger = true;
        }

        public List<GameFieldCoords> GetPosition()
        {
            List<GameFieldCoords> currentPosition = new List<GameFieldCoords>();

            foreach (GameFieldCoords position in this.snakeElements)
            {
                currentPosition.Add(position);
            }

            return currentPosition;
        }

        private void InitializeSnake(int length)
        {
            int horizontalOffset = 13;
            int verticalOffset = 18;

            int creatureTailPositionRow;
            int creatureTailPositionCol = verticalOffset;

            for (int counter = length; counter > 0; counter--)
            {
                creatureTailPositionRow = counter + horizontalOffset;

                this.snakeElements.Enqueue(new GameFieldCoords(creatureTailPositionRow, creatureTailPositionCol));
            }
        }
    }
}