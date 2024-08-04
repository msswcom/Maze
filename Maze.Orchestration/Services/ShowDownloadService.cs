using Maze.Database.Services;
using Maze.Integration.Services;
using Maze.Models.Integration;

namespace Maze.Orchestration.Services
{
    public class ShowDownloadService(
        ShowApiService showApiService,
        ShowSaveService showSaveService)
    {
        public async Task<MazeShow?> DownloadAsync(int id)
        {
            var mazeShow = await showApiService.GetAsync(id);

            await showSaveService.SaveAsync(mazeShow);

            return mazeShow;
        }
    }
}
