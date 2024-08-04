using Maze.Test.Stubs.Integration;

namespace Maze.Test.Integration
{
    public class ShowApiIsCorrectTest
    {
        [Theory]
        [InlineData(1)]
        public async void ShowApiIsCorrect(int id)
        {
            var showApiService = ShowApiServiceStub.Get();

            var mazeShow = await showApiService.GetAsync(id);

            Assert.Equal(mazeShow?.ID, id);
        }
    }
}