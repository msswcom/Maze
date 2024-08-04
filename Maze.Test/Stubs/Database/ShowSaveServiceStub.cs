using Maze.Database.Connections;
using Maze.Database.Services;

namespace Maze.Test.Stubs.Database
{
    public class ShowSaveServiceStub
    {
        public static ShowSaveService Get(MazeContext mazeContext)
        {
            var showGetService = ShowGetServiceStub.Get(mazeContext);
            var codebookAutoSaveByNameService = CodebookAutoSaveByNameServiceStub.Get(mazeContext);
            var externalSaveByAnyService = ExternalSaveByAnyServiceStub.Get(mazeContext);

            return new ShowSaveService(showGetService,
                codebookAutoSaveByNameService,
                externalSaveByAnyService,
                mazeContext);
        }
    }
}
