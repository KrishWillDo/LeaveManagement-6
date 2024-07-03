using LeaveManagement_6.Contracts;
using LeaveManagement_6.Data;
using Microsoft.EntityFrameworkCore;
using NuGet.Packaging.Signing;

namespace LeaveManagement_6.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private ApplicationDbContext DbContext;
        public GenericRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            DbContext.Add(entity);
            await DbContext.SaveChangesAsync();
            return entity;
        }

        public async Task AddRangeAsync(List<T> entities)
        {
            DbContext.AddRange(entities);
            await DbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await DbContext.Set<T>().FindAsync(id);
            if (entity != null)
            {
                DbContext.Set<T>().Remove(entity);
            }
            await DbContext.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);

            return entity != null;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await DbContext.Set<T>().ToListAsync();
        }

        public async Task<T?> GetAsync(int? id)
        {
            if (id == null)
            {
                return null;
            }

            return await DbContext.Set<T>().FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            //DbContext.Entry(entity).State = EntityState.Modified;
            DbContext.Update(entity);
            await DbContext.SaveChangesAsync();
        }
    }
}
