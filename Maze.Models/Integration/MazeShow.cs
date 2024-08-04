using Maze.Models.Database;

namespace Maze.Models.Integration
{
    public class MazeShow : Codebook
    {
        public string? Url { get; set; }
        public string? Type { get; set; }
        public string? Language { get; set; }
        public ICollection<string>? Genres { get; set; }
        public string? Status { get; set; }
        public decimal? Runtime { get; set; }
        public decimal? AverageRuntime { get; set; }
        public DateTime? Premiered { get; set; }
        public DateTime? Ended { get; set; }
        public string? OfficialSite { get; set; }
        public Schedule? Schedule { get; set; }
        public Rating? Rating { get; set; }
        public decimal? Weight { get; set; }
        public Network? Network { get; set; }
        public External? Externals { get; set; }
        public Image? Image { get; set; }
        public string? Summary { get; set; }
        public decimal? Updated { get; set; }
        public Links? _Links { get; set; }
    }
}
