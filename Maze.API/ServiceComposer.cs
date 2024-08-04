using Maze.API.Authorization;
using Maze.Orchestration;

namespace Maze.API
{
    public static class ServiceComposer
    {
        public static IServiceCollection AddAPI(this IServiceCollection services)
        {
            services.AddMazeOrchestration();
            services.AddTransient<AuthorizationFilter>();

            return services;
        }
    }
}
