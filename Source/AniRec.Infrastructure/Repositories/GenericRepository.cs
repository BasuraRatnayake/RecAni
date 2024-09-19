using AniRec.Domain.Interfaces;
using AniRec.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniRec.Infrastructure.Repositories {
    public class GenericRepository<T> : IGenericRepository<T> where T : class {
        private readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context) {
            _context = context;
        }

        public Task<T> AddAsync(T entity) {
            throw new NotImplementedException();
        }

        public Task<T> DeleteAsync(int id) {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync() {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int id) {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T entity) {
            throw new NotImplementedException();
        }
    }
}
