using Maze.Database.Connections;
using Maze.Database.Services;

namespace Maze.Test.Stubs.Database
{
    public class ShowGetServiceStub
    {
        public static ShowGetService Get(MazeContext mazeContext)
        {
            return new ShowGetService(mazeContext);
        }
    }
}
