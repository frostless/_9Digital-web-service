using _9Digital_web_service.Interfaces;
using System.Collections.Generic;


namespace _9Digital_web_service.Models
{


    public class ShowInfo : IFilterable<Response>
    {
        public string Country { get; set; }
        public string Description { get; set; }
        public bool Drm { get; set; }
        public int EpisodeCount { get; set; }
        public string Genre { get; set; }
        public Image Image { get; set; }
        public string Language { get; set; }
        public NextEpisode NextEpisode { get; set; }
        public string PrimaryColour { get; set; }
        public IEnumerable<Season> Seasons { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string TvChannel { get; set; }

        public Response Filter()
        {
            if (Drm == true && EpisodeCount > 0)
            {
                Response response = new Response
                {
                    Image = Image?.ShowImage,
                    Slug = Slug,
                    Title = Title
                };

                return response;
            }
            return null;

        }

    }
}
