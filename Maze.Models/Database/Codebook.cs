using System.ComponentModel.DataAnnotations.Schema;

namespace Maze.Models.Database
{
    public class Codebook
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public required int ID { get; set; }
        public required string Name { get; set; }
    }
}
