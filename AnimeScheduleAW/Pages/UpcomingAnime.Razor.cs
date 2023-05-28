using Microsoft.AspNetCore.Components;

namespace AnimeScheduleAW.Pages
{
    public partial class UpcomingAnime
    {
        [Inject]

        public HttpClient HttpClient { get; set; }

    }
}
