using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VedioGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VedioGameController : ControllerBase
    {
        static private List<VedioGame> videoGames = new List<VedioGame>
        {
            new VedioGame
            {
                Id = 1,
                Title = "Spider-Man 2",
                Platform = "PS5",
                Developer = "Insomniac Games",
                Publisher = "Sony Interactive Entertainment"
            },
            new VedioGame
            {
                Id = 2,
                Title = "God of War Ragnafdg",
                Platform = "PS5",
                Developer = "Santa Monica Studio",
                Publisher = "Sony Interactive Entertainment"
            },
            new VedioGame
            {
                Id = 3,
                Title = "Halo Infinite",
                Platform = "Xbox Series X",
                Developer = "343 Industries",
                Publisher = "Xbox Game Studios"
            },
            new VedioGame
            {
                Id = 4,
                Title = "The Legend of Zelda: Tears of the Kingdom",
                Platform = "Nintendo Switch",
                Developer = "Nintendo",
                Publisher = "Nintendo"
            }
        };

        [HttpGet]
        public ActionResult<List<VedioGame>> GetVideoGame()
        {
            return Ok(videoGames);
        }

    }
}
