namespace TetrisGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TTetrimino : Tetrimino
    {
        public TTetrimino()
        {
            this.Body = new char[2, 3];

            this.Body[0, 1] = '*';
            this.Body[1, 0] = '*';
            this.Body[1, 1] = '*';
            this.Body[1, 2] = '*';
        }
    }
}