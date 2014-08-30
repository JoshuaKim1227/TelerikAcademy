namespace SnakeGame
{
    public interface ICollisionHandler
    {
        void HandleCollisions(IHungryCreature creature, System.Collections.Generic.IList<IEatable> foodList, IRenderer renderer);
    }
}
