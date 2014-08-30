namespace TetrisGame
{
    using System;

    public class CollisionManager
    {
        ConsoleRenderer renderer;
        Tetrimino tetrimino;

        private int playFieldBorderSize = 2;

        public CollisionManager(ConsoleRenderer renderer, Tetrimino tetrimino)
        {
            this.renderer = renderer;
            this.tetrimino = tetrimino;
        }

        public void HandleCollision()
        {
            if (tetrimino.GetTopLeft().Row >= renderer.playFieldMatix.GetLength(0) - playFieldBorderSize)
            {
                tetrimino.RespondToCollision();
            }
        }
    }
}