
using Microsoft.EntityFrameworkCore;
using ShortListOfHospitalManagement.Context;

namespace ShortListOfHospitalManagement.Repository.Manager
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly HospitalContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(HospitalContext context)
        {
            //_context = context ?? throw new ArgumentNullException(nameof(context));
            _context = context;
            _dbSet = context.Set<T>();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
