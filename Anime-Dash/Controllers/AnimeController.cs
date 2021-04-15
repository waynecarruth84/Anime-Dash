using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Anime-Dash.Models;

namespace Anime-Dash.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class AnimeController : ControllerBase
        {
    private readonly dbContext _context;

    public AnimeController(dbContext context)
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