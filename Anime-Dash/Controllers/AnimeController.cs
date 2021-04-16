using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Anime_Dash.Models;
using System.Collections.Generic;

namespace Anime_Dash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimeController : ControllerBase
    {

        private readonly Models.dbAnimeContext _context;

        public AnimeController(Models.dbAnimeContext context)
        {
            _context = context;
        }
        
        //GET: api/Animes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Anime>>> GetAnimeItems()
        {
        return await _context.AnimeItems.ToListAsync();
        }

        //get api/anime/5
        /*
        [HttpGet]
        public async Task<ActionResult<Anime>> GetAnime(long id)
        {
            var anime = await _context.AnimeItems.FindAsync(id);
            if(anime == null)
            {
                return NotFound();
            }
            return anime;
        }
        */
        //post
        
        [HttpPost]
        public async Task<ActionResult<Anime>> PostAnime(Anime anime)
        {
            _context.AnimeItems.Add(anime);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnime", new { id = anime.id }, anime);
        }


        
    }
        
    
        


}