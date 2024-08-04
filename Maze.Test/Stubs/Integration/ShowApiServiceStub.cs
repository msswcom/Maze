using Maze.Integration.Services;

namespace Maze.Test.Stubs.Integration
{
    public class ShowApiServiceStub
    {
        public static ShowApiService Get()
        {
            var mazeIntegrationStub = MazeIntegrationStub.Get();

            return new ShowApiService(mazeIntegrationStub);
        }
    }
}
