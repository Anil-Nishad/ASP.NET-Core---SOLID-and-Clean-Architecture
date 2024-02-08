using HR.LeaveManagement.Domain.Common;

namespace HR.LeaveManagement.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        //Task<List<T>> CreateAsync(T entity);
        //Task<T> UpdateAsync(T entity);
        //Task<T> DeleteAsync(T entity);
        //Task<T> GetAsync();
        //Task<T> GetByIdAsync(int id);
        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IReadOnlyList<T>> GetAsync();
        Task<T> GetByIdAsync(int id);
    }
}
