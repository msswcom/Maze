
namespace Maze.Models.Integration
{
    public class Schedule
    {
        public string? Time { get; set; }
        public ICollection<string>? Days { get; set; }
    }
}
