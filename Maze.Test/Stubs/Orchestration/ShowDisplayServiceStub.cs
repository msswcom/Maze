using Maze.Database.Connections;
using Maze.Orchestration.Services;
using Maze.Test.Stubs.Database;

namespace Maze.Test.Stubs.Orchestration
{
    public class ShowDisplayServiceStub
    {
        public static ShowDisplayService Get(MazeContext mazeContext)
        {
            var showGetService = ShowGetServiceStub.Get(mazeContext);

            return new ShowDisplayService(showGetService);
        }
    }
}
