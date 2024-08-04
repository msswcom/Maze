using Maze.Models.Database;
using Microsoft.EntityFrameworkCore;
using Type = Maze.Models.Database.Type;

namespace Maze.Database.Connections
{
    public class MazeContext(MazeConnection mazeConnection) : DbContext
    {
        public DbSet<Country> Countries { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<External> Externals { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Network> Networks { get; set; }
        public DbSet<Show> Shows { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Type> Types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(mazeConnection.ConnectionString);
        }
    }
}
