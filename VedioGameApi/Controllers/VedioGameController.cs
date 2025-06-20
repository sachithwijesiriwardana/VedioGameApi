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
                Platform = "PS10",
                Developer = "Santa Monicafhghg Studio",
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
        [HttpGet("{id}")]
       
        public ActionResult<VedioGame> getVideoGameById(int id)
        {
            var game = videoGames.FirstOrDefault(x => x.Id == id);
            if(game is null)
                return NotFound();
            return Ok(game);

        }

        [HttpPost]
        public ActionResult<VedioGame> AddVideoGame (VedioGame newGame)
        {
            if (newGame is null)
                return BadRequest();
            newGame.Id = videoGames.Max(x => x.Id)+1;
            videoGames.Add(newGame);
            return CreatedAtAction(nameof(getVideoGameById),new {id = newGame.Id},newGame);
        }

        [HttpPost]
        public  IActionResult UpdateVideoGame(int id, VedioGame updatesGame)
        {
            var game = videoGames.FirstOrDefault(x => x.Id == id);
            if (game is null)
                return NotFound();
            return Ok(game);

        }



    }
}
