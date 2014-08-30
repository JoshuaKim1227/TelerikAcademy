namespace TetrisGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Tetrimino : IMovable, IRotatable, IRenderable
    {
        private readonly GameCoords initialPosition = new GameCoords(1, 5);
        private bool collided = false;

        public Tetrimino()
        {
            this.TopLeft = initialPosition;
            this.collided = false;
            this.IsStatic = false;
        }

        protected char[,] Body { get; set; }

        protected GameCoords TopLeft { get; set; }

        public bool IsStatic { get; set; }

        public void UpdatePosition()
        {
            if (!this.collided)
            {
                this.TopLeft.Row += 1;
            }
        }

        public void Rotate()
        {
            throw new NotImplementedException();
        }

        public char[,] GetBody()
        {
            return this.Body;
        }

        public GameCoords GetTopLeft()
        {
            return this.TopLeft;
        }


        public void MoveLeft()
        {
            this.TopLeft.Col -= 1;
        }

        public void MoveRight()
        {
            this.TopLeft.Col += 1;
        }

        public void RespondToCollision()
        {
            this.collided = true;
            this.IsStatic = true;
        }
    }
}