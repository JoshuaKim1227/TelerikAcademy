using System;

namespace SnakeGame
{
    public interface IUserController
    {
        event EventHandler OnUpPressed;

        event EventHandler OnRightPressed;

        event EventHandler OnDownPressed;

        event EventHandler OnLeftPressed;

        void ProcessInput();
    }
}