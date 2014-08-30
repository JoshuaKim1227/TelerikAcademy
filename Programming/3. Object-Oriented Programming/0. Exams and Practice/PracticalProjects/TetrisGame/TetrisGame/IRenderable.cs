using System;

namespace TetrisGame
{
    public interface IRenderable
    {
        char[,] GetBody();

        GameCoords GetTopLeft();
    }
}