using Maze.Database.Services;
using Maze.Models.Database;

namespace Maze.Orchestration.Services
{
    public class ShowDisplayService(ShowGetService showGetService)
    {
        public async Task<Show?> DisplayAsync(int id)
        {
            var show = await showGetService.GetAsync(id);

            return show;
        }
    }
}
