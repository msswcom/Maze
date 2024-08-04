using Maze.Database.Connections;
using Maze.Models.Database;
using Maze.Models.Integration;
using Microsoft.EntityFrameworkCore;
using Type = Maze.Models.Database.Type;

namespace Maze.Database.Services
{
    public class ShowSaveService(ShowGetService showGetService,
        CodebookAutoSaveByNameService codebookAutoSaveByNameService,
        ExternalSaveByAnyService externalSaveByAnyService,
        MazeContext mazeContext)
    {
        public async Task<Show?> SaveAsync(MazeShow? mazeShow)
        {
            Show? show = null;

            if (mazeShow != null)
            {
                show = await showGetService.GetAsync(mazeShow.ID);

                if (show == null)
                {
                    show = new Show
                    {
                        ID = mazeShow.ID,
                        Name = mazeShow.Name,
                    };

                    mazeContext.Add(show);
                }

                show.Url = mazeShow.Url;
                show.Runtime = mazeShow.Runtime;
                show.AverageRuntime = mazeShow.AverageRuntime;
                show.Premiered = mazeShow.Premiered;
                show.Ended = mazeShow.Ended;
                show.OfficialSite = mazeShow.OfficialSite;
                show.ScheduleTime = mazeShow.Schedule?.Time;
                show.RatingAverage = mazeShow.Rating?.Average;
                show.Weight = mazeShow.Weight;
                show.ImageMedium = mazeShow.Image?.Medium;
                show.ImageOriginal = mazeShow.Image?.Original;
                show.Summary = mazeShow.Summary;
                show.Updated = mazeShow.Updated;
                show.LinkSelf = mazeShow._Links?.Self?.Href;
                show.LinkPreviousEpisode = mazeShow._Links?.PreviousEpisode?.Href;
                show.LinkPreviousEpisodeName = mazeShow._Links?.PreviousEpisode?.Name;

                show.Type = await codebookAutoSaveByNameService.SaveAsync(new Type { Name = mazeShow.Type });
                show.Language = await codebookAutoSaveByNameService.SaveAsync(new Language { Name = mazeShow.Language });
                show.Status = await codebookAutoSaveByNameService.SaveAsync(new Status { Name = mazeShow.Status });

                if (mazeShow.Network != null)
                {
                    var network = await mazeContext.FindAsync<Network>(mazeShow.Network.ID);

                    if (network == null)
                    {
                        network = mazeShow.Network;
                    }
                    else
                    {
                        network.Name = mazeShow.Network.Name;
                        network.OfficialSite = mazeShow.Network.OfficialSite;
                    }

                    network.Country = await codebookAutoSaveByNameService.SaveAsync(network.Country);

                    show.Network = network;
                }

                show.External = await externalSaveByAnyService.SaveAsync(mazeShow.Externals);

                if (mazeShow.Genres != null)
                {
                    foreach (var genre in mazeShow.Genres)
                    {
                        var showGenre = await codebookAutoSaveByNameService.SaveAsync(new Genre { Name = genre });

                        if (showGenre != null && !show.Genres.Select(o => o.ID).Contains(showGenre.ID))
                        {
                            show.Genres.Add(showGenre);

                            mazeContext.Entry(showGenre).State = EntityState.Unchanged;
                        }
                    }
                }

                if (mazeShow.Schedule?.Days != null)
                {
                    foreach (var day in mazeShow.Schedule.Days)
                    {
                        var showDay = await codebookAutoSaveByNameService.SaveAsync(new Day { Name = day });

                        if (showDay != null && !show.Days.Select(o => o.ID).Contains(showDay.ID))
                        {
                            show.Days.Add(showDay);

                            mazeContext.Entry(showDay).State = EntityState.Unchanged;
                        }
                    }
                }
            }

            mazeContext.SaveChanges();

            return show;
        }
    }
}
