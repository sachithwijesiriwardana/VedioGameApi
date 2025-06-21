using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VedioGameApi.Data;

namespace VedioGameApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VedioGameController(VideoGameDbContext context) : ControllerBase
    {

        private readonly VideoGameDbContext _context = context;       

        [HttpGet]
        public async Task<ActionResult<List<VedioGame>>> GetVideoGames()
        {
            return Ok(await _context.VideoGames.ToListAsync());
        }


        [HttpGet("{id}")]

        public async Task<ActionResult<VedioGame>> GetVideoGameById(int id)
        {
            var game = await _context.VideoGames.FindAsync(id);
            if (game is null)
                return NotFound();
            return Ok(game);

        }

        [HttpPost]
        public async Task<ActionResult<VedioGame>> AddvideoGame(VedioGame newgame)
        {
            if (newgame is null)
                return BadRequest();

            _context.VideoGames.Add(newgame);
            await _context.SaveChangesAsync();


            return CreatedAtAction(nameof(GetVideoGameById), new { id = newgame.Id }, newgame);
        }

        [HttpPut("{id}")]
        public async Task <IActionResult> UpdateVideoGame(int id, VedioGame updatesGame)
        {
            var game = await _context.VideoGames.FindAsync(id);
            if (game is null)
                return NotFound();
            game.Title = updatesGame.Title;
            game.Platform = updatesGame.Platform;
            game.Developer = updatesGame.Developer;
            game.Publisher = updatesGame.Publisher;

            await _context.SaveChangesAsync();

            return Ok(new { message = "Updated sucessfully!" });


        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVideoGame(int id)
        {
            var game = await _context.VideoGames.FindAsync(id);
            if (game is null)
                return NotFound();
            _context.VideoGames.Remove(game);
            await _context.SaveChangesAsync();
            return Ok(new { message = "Deleted sucessfully" });

        }



    }
}
