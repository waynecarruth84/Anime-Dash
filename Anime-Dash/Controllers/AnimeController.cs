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

        }
        

}