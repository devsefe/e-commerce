using DomainModel.Context;
using DomainModel.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace DomainModel.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly IUnitOfWork _unitOfWork;
        private readonly DbSet<T> _dbSet;

        public Repository(
            AppDbContext context,
            IUnitOfWork unitOfWork)
        {
            this._context = context;
            this._unitOfWork = unitOfWork;
            _dbSet = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await _unitOfWork.BeginTransactionAsync();
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            await _unitOfWork.BeginTransactionAsync();
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            await _unitOfWork.BeginTransactionAsync();
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
