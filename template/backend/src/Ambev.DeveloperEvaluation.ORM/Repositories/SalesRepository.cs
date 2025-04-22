using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class SalesRepository : ISalesRepository
    {

        private readonly DefaultContext _context;

        public SalesRepository(DefaultContext context)
        {
            _context = context;
        }

        public async Task<Sales> CreateAsync(Sales sale, CancellationToken cancellationToken = default)
        {
            await _context.Sales.AddAsync(sale, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);
            return sale;
        }


        public async Task<bool> DeleteAsync(int Id, CancellationToken cancellationToken = default)
        {
            var sale = await GetByIdAsync(Id, cancellationToken);
            if (sale == null)
                return false;

            _context.Sales.Remove(sale);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }


        public async Task<Sales?> GetByIdAsync(int Id, CancellationToken cancellationToken = default)
        {
            return await _context.Sales.FirstOrDefaultAsync(o => o.Id == Id, cancellationToken);
        }
    }
}
