
namespace Maze.Integration.Connections
{
    public class MazeIntegration
    {
        public HttpClient Http { get; }

        public MazeIntegration(HttpClient httpClient)
        {
            httpClient.BaseAddress ??= new Uri(MazeUrl.API);

            Http = httpClient;
        }
    }
}
