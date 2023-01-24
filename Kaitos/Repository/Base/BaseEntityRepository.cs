using Kaitos.Data.DataBaseContext;
using Kaitos.Models;
using Kaitos.Repository.Base.Interface;
using Microsoft.EntityFrameworkCore;

namespace Kaitos.Repository.Base
{
    public class BaseEntityRepository<T> : IBaseEntityRepository<T>
        where T : class, IBaseEntity, new()
    {
        protected readonly KatiosDbContext _context;
        protected readonly DbSet<T> _db;
        public BaseEntityRepository(KatiosDbContext context)
        {
            _context = context;
            _db = context.Set<T>();
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            await _db.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task DeleteAsync(int id)
        {
            var result = await _db.FirstOrDefaultAsync(e => e.Id == id)
                ?? throw new Exception("UnDefined");
            result.DeletedAt = DateTime.Now;
            //_db.Update(queryResult);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync
                (
                    string? includes = null,
                    bool tracking = false
                )
        {
            var queryResult = _db.AsQueryable<T>();

            if (!tracking) queryResult = queryResult.AsNoTracking();


            if (includes != null)
            {
                foreach (var included in includes.Split(','))
                {
                    queryResult = queryResult.
                         Include(included.Trim().Replace(" ", ""));
                }
            }
            return await queryResult.ToListAsync();
        }


        public virtual async Task<T> GetByIdAsync
            (int id, string? includes = null, bool tracking = false)
        {
            var result = _db.AsQueryable<T>();
            if (!tracking) result = result.AsNoTracking();

            if (includes != null)
            {
                foreach (var included in includes.Split(','))
                {
                    result = result.
                         Include(included.Trim().Replace(" ", ""));
                }
            }

            return await result.FirstOrDefaultAsync(e => e.Id == id)
                ?? throw new Exception("UnDefined");
        }
        public virtual async Task UpdateAsync(T entity)
        {
            var result = await _db.
                AsNoTracking().
                FirstOrDefaultAsync(t => t.Id == entity.Id)
                ?? throw new Exception("Undefined");
            entity.CreatedAt = result.CreatedAt;
            entity.UpdatedAt = DateTime.Now;
            _context.Entry(entity).State = EntityState.Modified;
            //_db.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
