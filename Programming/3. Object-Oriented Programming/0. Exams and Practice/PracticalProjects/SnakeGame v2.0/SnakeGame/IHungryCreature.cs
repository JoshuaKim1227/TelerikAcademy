namespace SnakeGame
{
    public interface IHungryCreature: IRenderable
    {
        void ChangeDirection(string newDirection);
        void GetBigger();
        bool IsDestroyed { get; set; }
        void Update();
    }
}
