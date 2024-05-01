namespace DomainModel.Repository
{
    public interface IRepository<T> where T : class
    {
        Task CreateAsync(T entity);
        Task<IEnumerable<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
