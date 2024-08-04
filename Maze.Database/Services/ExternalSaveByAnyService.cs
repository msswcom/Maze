using Maze.Database.Connections;
using Maze.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Maze.Database.Services
{
    public class ExternalSaveByAnyService(MazeContext mazeContext)
    {
        public async Task<External?> SaveAsync(External? t)
        {
            if (t?.Tvrage == null
                && t?.Thetvdb == null
                && String.IsNullOrEmpty(t?.Imdb))
            {
                return null;
            }

            var dbT = await mazeContext.Externals.FirstOrDefaultAsync(
                o => (t.Tvrage != null && (o.Tvrage == t.Tvrage))
                || (t.Thetvdb != null && o.Thetvdb == t.Thetvdb)
                || (!String.IsNullOrEmpty(t.Imdb) && o.Imdb == t.Imdb));

            if (dbT == null)
            {
                mazeContext.Add(t);
            }
            else
            {
                mazeContext.Entry(dbT).State = EntityState.Detached;

                t.ID = dbT.ID;

                mazeContext.Update(t);
            }

            mazeContext.SaveChanges();

            return t;
        }
    }
}
