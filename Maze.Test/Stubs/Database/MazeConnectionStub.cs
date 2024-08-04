using Maze.Database.Connections;

namespace Maze.Test.Stubs.Database
{
    public class MazeConnectionStub
    {
        public static MazeConnection Get()
        {
            var configuration = ConfigurationStub.Get();

            return new MazeConnection(configuration);
        }
    }
}
