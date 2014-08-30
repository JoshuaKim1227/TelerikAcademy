using System;

namespace SnakeGame
{
    public class UsersManager : IUsersManager
    {
        public string RequestUserName(IRenderer renderer)
        {
            renderer.RenderUsernameRequest();
            string userName = Console.ReadLine();

            return userName;
        }
    }
}