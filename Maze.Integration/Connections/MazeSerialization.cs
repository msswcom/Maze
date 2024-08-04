using System.Text.Json;
using System.Text.Json.Serialization;

namespace Maze.Integration.Connections
{
    public class MazeSerialization
    {
        public static JsonSerializerOptions Options { get; set; } = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
            ReferenceHandler = ReferenceHandler.IgnoreCycles
        };
    }
}
