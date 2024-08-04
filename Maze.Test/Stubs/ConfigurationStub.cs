using Microsoft.Extensions.Configuration;

namespace Maze.Test.Stubs
{
    public class ConfigurationStub
    {
        public static IConfiguration Get()
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<ConfigurationStub>()
                .Build();

            return configuration;
        }
    }
}
