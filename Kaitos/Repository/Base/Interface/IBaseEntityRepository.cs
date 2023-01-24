using Kaitos.Models;

namespace Kaitos.Repository.Base.Interface
{
    public interface IBaseEntityRepository<T>
        where T : class, IBaseEntity, new()
    {
        Task<T> GetByIdAsync(int id, string? includes = null, bool tracking = false);
        Task<IEnumerable<T>> GetAllAsync(
                string? includes = null,
                bool tracking = false
                                    );
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}
