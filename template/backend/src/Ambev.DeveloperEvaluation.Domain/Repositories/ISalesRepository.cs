using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface ISalesRepository
    {

        Task<Sales> CreateAsync(Sales sale, CancellationToken cancellationToken = default);
        Task<Sales?> GetByIdAsync(int id, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(int id, CancellationToken cancellationToken = default);
    }
}
