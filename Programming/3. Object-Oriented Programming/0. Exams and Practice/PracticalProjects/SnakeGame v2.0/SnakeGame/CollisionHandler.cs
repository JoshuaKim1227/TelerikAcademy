using System.Collections.Generic;
using System.Linq;

namespace SnakeGame
{
    public class CollisionHandler : ICollisionHandler
    {
        public void HandleCollisions(IHungryCreature creature, IList<IEatable> foodList, IRenderer renderer)
        {
            HandleEating(creature, foodList);
            HandleCollision(creature, renderer);
        }

        private void HandleEating(IHungryCreature snake, IList<IEatable> listOfEatables)
        {
            foreach (IEatable eatable in listOfEatables)
            {
                foreach (GameFieldCoords snakeElementPosition in snake.GetPosition())
                {
                    if (eatable.GetPosition()[0].Row == snakeElementPosition.Row
                        && eatable.GetPosition()[0].Col == snakeElementPosition.Col)
                    {
                        snake.GetBigger();
                        eatable.RespondToEating();
                    }
                }
            }
        }

        private void HandleCollision(IHungryCreature creature, IRenderer renderer)
        {
            List<GameFieldCoords> creatureElements = new List<GameFieldCoords>();

            foreach (GameFieldCoords element in creature.GetPosition())
            {
                creatureElements.Add(element);
            }

            foreach (GameFieldCoords element in creatureElements)
            {
                if (element.Row >= renderer.GameFieldSize.Row || element.Row < 0
                    || element.Col >= renderer.GameFieldSize.Col || element.Col < 0)
                {
                    creature.IsDestroyed = true;
                }
            }

            for (int element = 0; element < creatureElements.Count - 1; element++)
            {
                if (creatureElements.Last().Row == creatureElements[element].Row
                    && creatureElements.Last().Col == creatureElements[element].Col)
                {
                    creature.IsDestroyed = true;
                }
            }
        }
    }
}