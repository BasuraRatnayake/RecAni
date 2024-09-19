using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniRec.Domain.Interfaces {
    public interface IGenericRepository<T> where T: class {
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
        Task<T> GetByIdAsync(int id);   
        Task<IEnumerable<T>> GetAllAsync();
    }
}
