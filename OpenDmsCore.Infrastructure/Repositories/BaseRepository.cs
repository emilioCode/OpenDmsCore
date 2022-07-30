using Microsoft.EntityFrameworkCore;
using OpenDmsCore.Core.Entities;
using OpenDmsCore.Core.Interfaces;
using OpenDmsCore.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenDmsCore.Infrastructure.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly OPEN_DMSContext _context;
        protected DbSet<T> _entities;
        public BaseRepository(OPEN_DMSContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _entities.AddAsync(entity);
        }

        public async Task Delete(int id)
        {
            T entity = await GetById(id);
            _context.Remove<T>(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
        }
    }
}
