using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniRec.Domain.Entities {
    public class AnimeGenre {
        public int Id { get; set; }
        public Anime AnimeId { get; set; }
        public Genre GenreId { get; set; }
    }
}
