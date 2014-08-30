﻿namespace TetrisGame
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IMovable
    {
        void UpdatePosition();

        void MoveLeft();

        void MoveRight();
    }
}