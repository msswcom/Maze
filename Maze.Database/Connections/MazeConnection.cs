using Microsoft.Extensions.Configuration;

namespace Maze.Database.Connections
{
    public class MazeConnection
    {
        public string ConnectionString { get; }

        public MazeConnection(IConfiguration configuration)
        {
            var connectionString = configuration[MazeDatabase.Connection];

            ArgumentException.ThrowIfNullOrEmpty(connectionString);

            ConnectionString = connectionString;
        }
    }
}
