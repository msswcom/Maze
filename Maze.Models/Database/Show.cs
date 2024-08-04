namespace Maze.Models.Database
{
    public class Show : Codebook
    {
        public string? Url { get; set; }
        public Type? Type { get; set; }
        public Language? Language { get; set; }
        public List<Genre> Genres { get; set; } = [];
        public Status? Status { get; set; }
        public decimal? Runtime { get; set; }
        public decimal? AverageRuntime { get; set; }
        public DateTime? Premiered { get; set; }
        public DateTime? Ended { get; set; }
        public string? OfficialSite { get; set; }
        public string? ScheduleTime { get; set; }
        public List<Day> Days { get; set; } = [];
        public decimal? RatingAverage { get; set; }
        public decimal? Weight { get; set; }
        public Network? Network { get; set; }
        public External? External { get; set; }
        public string? ImageMedium { get; set; }
        public string? ImageOriginal { get; set; }
        public string? Summary { get; set; }
        public decimal? Updated { get; set; }
        public string? LinkSelf { get; set; }
        public string? LinkPreviousEpisode { get; set; }
        public string? LinkPreviousEpisodeName { get; set; }
    }
}
