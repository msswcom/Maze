using Maze.Database;
using Maze.Database.Services;
using Maze.Integration;
using Maze.Orchestration.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Maze.Orchestration
{
    public static class ServiceComposer
    {
        public static IServiceCollection AddMazeOrchestration(this IServiceCollection services)
        {
            services.AddMazeDatabase();
            services.AddMazeIntegration();
            services.AddTransient<ShowDisplayService>();
            services.AddTransient<ShowDownloadService>();

            return services;
        }
    }
}
