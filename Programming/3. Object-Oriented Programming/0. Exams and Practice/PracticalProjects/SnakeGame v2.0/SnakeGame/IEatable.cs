using System.Collections.Generic;

namespace SnakeGame
{
    public interface IEatable : IRenderable
    {
        List<GameFieldCoords> GetPosition();
        bool IsEaten { get; }
        char RenderingSymbol { get; }
        void RespondToEating();
    }
}
