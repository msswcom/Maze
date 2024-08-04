
namespace Maze.Test.Stubs.Integration
{
    public class HttpClientStub
    {
        public static readonly HttpClient HttpClient = new HttpClient(new SocketsHttpHandler
        {
            PooledConnectionLifetime = TimeSpan.FromMinutes(15)
        });
    }
}
