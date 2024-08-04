using Maze.Integration.Connections;

namespace Maze.Test.Stubs.Integration
{
    public class MazeIntegrationStub
    {
        public static MazeIntegration Get()
        {
            var httpClient = HttpClientStub.HttpClient;

            return new MazeIntegration(httpClient);
        }
    }
}
