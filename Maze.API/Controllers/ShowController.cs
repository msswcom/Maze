using Maze.API.Authorization;
using Maze.Models.Database;
using Maze.Models.Integration;
using Maze.Orchestration.Services;
using Microsoft.AspNetCore.Mvc;

namespace Maze.API.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ShowController(ShowDownloadService showDownloadService, ShowDisplayService showDisplayService) : ControllerBase
    {
        [HttpPost("{id}")]
        //uncomment to add authorization
        //[ServiceFilter(typeof(AuthorizationFilter))]
        public async Task<MazeShow?> Download(int id)
        {
            return await showDownloadService.DownloadAsync(id);
        }

        [HttpGet("{id}")]
        public async Task<Show?> Display(int id)
        {
            return await showDisplayService.DisplayAsync(id);
        }
    }
}
