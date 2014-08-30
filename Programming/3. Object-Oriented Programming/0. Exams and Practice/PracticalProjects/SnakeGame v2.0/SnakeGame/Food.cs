using System.Collections.Generic;

namespace SnakeGame
{
    public class Food : IEatable
    {
        private readonly char renderingSymbol = '@';

        private GameFieldCoords foodCoords;

        public Food(GameFieldCoords position)
        {
            this.foodCoords = new GameFieldCoords(position.Row, position.Col);
        }

        public char RenderingSymbol
        {
            get
            {
                return this.renderingSymbol;
            }
        }

        public bool IsEaten { get; private set; }

        public void RespondToEating()
        {
            this.IsEaten = true;
        }

        public List<GameFieldCoords> GetPosition()
        {
            List<GameFieldCoords> foodPosition = new List<GameFieldCoords>();

            foodPosition.Add(this.foodCoords);

            return foodPosition;
        }
    }
}