namespace SnakeGame
{
    public interface IRenderer
    {
        GameFieldCoords GameFieldSize { get; }
        void EnqueueForRendering(IRenderable objForRendering);
        void RenderScores();
        void RenderAll();
        void RenderEndGame();
        void RenderUsernameRequest();
        void ClearConsole();
    }
}