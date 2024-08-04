using Maze.Database.Connections;
using Maze.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace Maze.Database.Services
{
    public class CodebookAutoSaveByNameService(MazeContext mazeContext)
    {
        public async Task<T?> SaveAsync<T>(T? t) where T : CodebookAuto
        {
            if (String.IsNullOrEmpty(t?.Name))
            {
                return null;
            }

            var dbSet = mazeContext.Set<T>();

            var dbT = await dbSet.FirstOrDefaultAsync(o => o.Name == t.Name);

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
