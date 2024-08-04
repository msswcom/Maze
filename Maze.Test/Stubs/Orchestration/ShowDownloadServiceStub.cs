using Maze.Database.Connections;
using Maze.Orchestration.Services;
using Maze.Test.Stubs.Database;
using Maze.Test.Stubs.Integration;

namespace Maze.Test.Stubs.Orchestration
{
    public class ShowDownloadServiceStub
    {
        public static ShowDownloadService Get(MazeContext mazeContext)
        {
            var showApiService = ShowApiServiceStub.Get();
            var showSaveService = ShowSaveServiceStub.Get(mazeContext);

            return new ShowDownloadService(showApiService, showSaveService);
        }
    }
}
