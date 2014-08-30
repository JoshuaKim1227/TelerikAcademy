using System;

namespace SnakeGame
{
    public class UsersManager
    {
        public string RequestUserName(ConsoleRenderer renderer)
        {
            renderer.RenderUserRequest();
            string userName = Console.ReadLine();

            return userName;
        }
    }
}