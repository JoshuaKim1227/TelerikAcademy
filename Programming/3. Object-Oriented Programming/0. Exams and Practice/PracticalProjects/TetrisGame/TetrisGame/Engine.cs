namespace TetrisGame
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    public class Engine
    {
        private ConsoleRenderer renderer;
        private Tetrimino tetrimino;
        private IUserController controller;
        private CollisionManager collisionManager;
        private char[,] staticTetriminos;

        public Engine(IUserController controller)
        {
            this.renderer = new ConsoleRenderer(20, 15);
            this.tetrimino = new TTetrimino();
            this.collisionManager = new CollisionManager(renderer, tetrimino);
            this.controller = controller;
            this.staticTetriminos = new char[renderer.Rows, renderer.Cols];
        }

        private void StoreStaticTetrimino()
        {
            int lastRow = this.tetrimino.GetBody().GetLength(0);
            int lastCol = this.tetrimino.GetBody().GetLength(1);

            for (int row = this.tetrimino.GetTopLeft().Row; row < row + lastRow; row++)
            {
                for (int col = this.tetrimino.GetTopLeft().Col; col < col + lastCol; col++)
                {
                    this.staticTetriminos[row, col] = '*';
                }
            }
        }

        private void MakeTetrimino()
        {
            if (tetrimino.IsStatic)
            {
                tetrimino = new TTetrimino();
            }
        }

        public void MoveTetriminoLeft()
        {
            tetrimino.MoveLeft();
        }

        public void MoveTetriminoRight()
        {
            tetrimino.MoveRight();
        }

        public void RunGame()
        {
            while (true)
            {
                controller.ProcessInput();

                tetrimino.UpdatePosition();

                collisionManager.HandleCollision();

                if (tetrimino.IsStatic)
                {
                    StoreStaticTetrimino();
                    MakeTetrimino();
                }

                renderer.EnqueueForRendering(tetrimino, staticTetriminos);

                renderer.RenderAll();

                Thread.Sleep(100);

                renderer.ClearQueue();
            }
        }
    }
}