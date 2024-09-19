using AniRec.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniRec.Domain.Interfaces {
    public interface IUnitOfWork {
        IGenericRepository<Anime> AnimeRepository { get; }
        IGenericRepository<User> UserRepository { get; }
        Task<int> CompleteAsync();
    }
}
