using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Anime_Dash.Models
{
    public class Anime
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long animeid { get; set; }
        // public long id { get; set; }
        public string Name { get; set; }
        public string genre { get; set; }
        public string description { get; set; }
        public int year { get; set; }
        public int episodes { get; set; }

        public int seasons { get; set; }
        public string yearly_quarter { get; set; }

    }
}
