using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Mountain_Trips_and_Landmarks.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;

        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()=> await _context.Set<T>().ToListAsync();

        public async Task<IEnumerable<T>> GetAllAsync(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> querry = _context.Set<T>();
            querry = includeProperties.Aggregate(querry, (current, includeProperties) => current.Include(includeProperties));
            return await querry.ToListAsync();

        }

        public async Task<T> GetByIdAsync(int id)=>  await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            
        public async Task UpdateAsync(int id, T entity)
        {
            var entityOld = await _context.Set<T>().FirstOrDefaultAsync(n => n.Id == id);
            EntityEntry entityEntryOld = _context.Entry<T>(entityOld);
            entityEntryOld.State = EntityState.Deleted;

            entity.Id = id;
            EntityEntry entityEntry = _context.Entry<T>(entity);
            entityEntry.State = EntityState.Modified;
            
            await _context.SaveChangesAsync();
        }
    }
}
