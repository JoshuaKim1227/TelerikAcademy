using System;
using System.Collections.Generic;

namespace SnakeGame
{
    public interface IRenderable
    {
        char RenderingSymbol { get; }

        List<GameFieldCoords> GetPosition();
    }
}