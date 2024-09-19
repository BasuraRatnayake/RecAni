using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniRec.Domain.Entities {
    public class UserAnime {
        public int Id { get; set; }
        public Anime AnimeId { get; set; }
        public User UserId { get; set; }
    }
}
