using System;

namespace SnakeGame
{
    public interface IRenderer
    {
        void EnqueueForRendering(IRenderable objForRendering);

        void RenderAll();
    }
}