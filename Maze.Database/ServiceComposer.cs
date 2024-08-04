using Maze.Database.Connections;
using Maze.Database.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Maze.Database
{
    public static class ServiceComposer
    {
        public static IServiceCollection AddMazeDatabase(this IServiceCollection services)
        {
            services.AddTransient<MazeConnection>();
            services.AddTransient<MazeContext>();
            services.AddTransient<CodebookAutoSaveByNameService>();
            services.AddTransient<ExternalSaveByAnyService>();
            services.AddTransient<ShowGetService>();
            services.AddTransient<ShowSaveService>();

            return services;
        }
    }
}
