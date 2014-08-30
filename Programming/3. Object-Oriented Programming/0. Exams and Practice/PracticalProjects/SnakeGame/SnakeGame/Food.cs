using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public class Food : IRenderable
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