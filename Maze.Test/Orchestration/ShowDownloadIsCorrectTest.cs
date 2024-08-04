using Maze.Test.Stubs.Database;
using Maze.Test.Stubs.Orchestration;

namespace Maze.Test.Orchestration
{
    public class ShowDownloadIsCorrectTest
    {
        [Theory]
        [InlineData(1)]
        public async void ShowDownloadIsCorrect(int id)
        {
            var mazeContext = MazeContextStub.Get();

            var showDownloadService = ShowDownloadServiceStub.Get(mazeContext);

            var mazeShow = await showDownloadService.DownloadAsync(id);

            Assert.NotNull(mazeShow);
        }
    }
}