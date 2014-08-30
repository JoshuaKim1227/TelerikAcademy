namespace TetrisGame
{
    using System;

    public class ConsoleRenderer
    {
        private GameBordersRenderer bordersRenderer;
        public char[,] playFieldMatix;

        public ConsoleRenderer(int rows, int cols)
        {
            Console.Title = "Tetris by N. Donchev";
            Console.CursorVisible = false;

            this.Rows = rows;
            this.Cols = cols;

            this.bordersRenderer = new GameBordersRenderer(rows, cols);
            this.playFieldMatix = new char[rows, cols];
        }

        public int Rows { get; private set; }

        public int Cols { get; private set; }

        public void EnqueueForRendering(Tetrimino fallingTetrimino, char[,] staticTetriminos)
        {
            this.EnqueueFallingTetrimino(fallingTetrimino);
            this.EnqueueStaticTetriminos(staticTetriminos);
        }

        private void EnqueueFallingTetrimino(Tetrimino tetrimino)
        {
            char[,] tetriminoBody = tetrimino.GetBody();

            int tetriminoBodyRows = tetriminoBody.GetLength(0);
            int tetriminoBodyCols = tetriminoBody.GetLength(1);

            int lastRow = Math.Min(tetrimino.GetTopLeft().Row + tetriminoBodyRows, this.playFieldMatix.GetLength(0));
            int lastCol = Math.Min(tetrimino.GetTopLeft().Col + tetriminoBodyCols, this.playFieldMatix.GetLength(1));

            for (int row = tetrimino.GetTopLeft().Row; row < lastRow; row++)
            {
                for (int col = tetrimino.GetTopLeft().Col; col < lastCol; col++)
                {
                    this.playFieldMatix[row, col] = tetriminoBody[row - tetrimino.GetTopLeft().Row, col - tetrimino.GetTopLeft().Col];
                }
            }
        }

        private void EnqueueStaticTetriminos(char[,] staticTetriminos)
        {
            this.playFieldMatix = staticTetriminos;

        }

        public void RenderAll()
        {
            int leftBorderSize = 3;
            int topBorderSize = 1;

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    Console.SetCursorPosition(col + leftBorderSize, row + topBorderSize);

                    Console.Write(this.playFieldMatix[row, col]);
                }
            }

            Console.WriteLine("\n");
        }

        public void ClearQueue()
        {
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    this.playFieldMatix[row, col] = ' ';
                }
            }
        }
    }
}