using Maze.Integration.Connections;
using Maze.Integration.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Maze.Integration
{
    public static class ServiceComposer
    {
        public static IServiceCollection AddMazeIntegration(this IServiceCollection services)
        {
            services.AddHttpClient<MazeIntegration>();
            services.AddTransient<ShowApiService>();

            return services;
        }
    }
}
