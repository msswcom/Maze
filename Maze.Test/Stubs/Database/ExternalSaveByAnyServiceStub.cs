using Maze.Database.Connections;
using Maze.Database.Services;

namespace Maze.Test.Stubs.Database
{
    public class ExternalSaveByAnyServiceStub
    {
        public static ExternalSaveByAnyService Get(MazeContext mazeContext)
        {
            return new ExternalSaveByAnyService(mazeContext);
        }
    }
}
