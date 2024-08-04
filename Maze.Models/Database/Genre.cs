namespace Maze.Models.Database
{
    public class Genre : CodebookAuto
    {
        public List<Show> Shows { get; set; } = [];
    }
}
