namespace SnakeGame
{
    public interface IEngine
    {
        void GameOver();
        void RunGame();
        void CreatureDirectionChange(string newDirection);
    }
}
