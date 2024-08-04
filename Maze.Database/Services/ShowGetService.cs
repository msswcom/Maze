using Maze.Database.Connections;
using Maze.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Maze.Database.Services
{
    public class ShowGetService(MazeContext mazeContext)
    {
        public async Task<Show?> GetAsync(int id)
        {
            var show = await mazeContext.Shows
                .Include(o => o.Type)
                .Include(o => o.Language)
                .Include(o => o.Genres)
                .Include(o => o.Status)
                .Include(o => o.Days)
                .Include(o => o.Network).ThenInclude(o => o.Country)
                .Include(o => o.External)
                .FirstOrDefaultAsync(o => o.ID == id);

            return show;
        }
    }
}
