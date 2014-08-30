﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisGame
{
    public interface IUserController
    {
        event EventHandler OnLeftPressed;

        event EventHandler OnRightPressed;

        void ProcessInput();
    }
}
