using Maze.Database.Connections;

namespace Maze.Test.Stubs.Database
{
    public class MazeContextStub
    {
        public static MazeContext Get()
        {
            var mazeConnection = MazeConnectionStub.Get();

            return new MazeContext(mazeConnection);
        }
    }
}
