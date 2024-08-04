using Maze.Test.Stubs.Database;
using Maze.Test.Stubs.Orchestration;

namespace Maze.Test.Orchestration
{
    public class ShowDisplayIsCorrectTest
    {
        [Theory]
        [InlineData(1)]
        public async void ShowDisplayIsCorrect(int id)
        {
            var mazeContext = MazeContextStub.Get();

            var showDownloadService = ShowDownloadServiceStub.Get(mazeContext);
            var showDisplayService = ShowDisplayServiceStub.Get(mazeContext);

            var mazeShow = await showDownloadService.DownloadAsync(id);
            var show = await showDisplayService.DisplayAsync(id);

            Assert.NotNull(mazeShow?.Type);
            Assert.NotNull(show?.Type);

            Assert.Equal(mazeShow.Type, show.Type.Name);
        }
    }
}