using AniRec.Domain.Entities;
using AniRec.Domain.Interfaces;
using AniRec.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniRec.Infrastructure.UnitOfWork {
    public class UnitOfWork : IUnitOfWork {
        private readonly ApplicationDbContext _context;

        public IGenericRepository<Anime> AnimeRepository => throw new NotImplementedException();
        public IGenericRepository<User> UserRepository => throw new NotImplementedException();

        public Task<int> CompleteAsync() {
            throw new NotImplementedException();
        }
    }
}
