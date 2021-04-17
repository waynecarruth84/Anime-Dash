using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Anime_Dash.Models
{
    public class dbAnimeContext : DbContext
    {
        public dbAnimeContext(DbContextOptions<dbAnimeContext> options) 
            : base(options) 
        {
        }

        public DbSet<Anime> AnimeItems { get; set; }
        public DbSet<User> UserItems { get; set; }

    }
}
