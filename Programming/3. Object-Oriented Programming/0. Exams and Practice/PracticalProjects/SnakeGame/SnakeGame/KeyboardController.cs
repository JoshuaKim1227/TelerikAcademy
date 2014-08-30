using System;

namespace SnakeGame
{
    public class KeyboardController : IUserController
    {
        public event EventHandler OnUpPressed;

        public event EventHandler OnRightPressed;

        public event EventHandler OnDownPressed;

        public event EventHandler OnLeftPressed;

        public void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                var keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    if (this.OnUpPressed != null)
                    {
                        this.OnUpPressed(this, new EventArgs());
                    }
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    if (this.OnRightPressed != null)
                    {
                        this.OnRightPressed(this, new EventArgs());
                    }
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    if (this.OnDownPressed != null)
                    {
                        this.OnDownPressed(this, new EventArgs());
                    }
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    if (this.OnLeftPressed != null)
                    {
                        this.OnLeftPressed(this, new EventArgs());
                    }
                }
            }
        }
    }
}