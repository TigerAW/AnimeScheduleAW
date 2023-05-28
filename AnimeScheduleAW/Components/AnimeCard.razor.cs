using Microsoft.AspNetCore.Components;

namespace AnimeScheduleAW.Components
{
    public partial class AnimeCard
    {
        [Parameter]
        public Anime Anime { get; set; } = default;
    }
}
