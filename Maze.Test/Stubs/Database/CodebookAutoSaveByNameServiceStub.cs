using Maze.Database.Connections;
using Maze.Database.Services;

namespace Maze.Test.Stubs.Database
{
    public class CodebookAutoSaveByNameServiceStub
    {
        public static CodebookAutoSaveByNameService Get(MazeContext mazeContext)
        {
            return new CodebookAutoSaveByNameService(mazeContext);
        }
    }
}
