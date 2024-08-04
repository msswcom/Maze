using Maze.Integration.Connections;
using Maze.Models.Integration;
using System.Net.Http.Json;

namespace Maze.Integration.Services
{
    public class ShowApiService(MazeIntegration mazeIntegration)
    {
        public async Task<MazeShow?> GetAsync(int id)
        {
            var url = $"{MazeUrl.Show}/{id}";

            return await mazeIntegration.Http.GetFromJsonAsync<MazeShow>(url, MazeSerialization.Options);
        }
    }
}
