using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DefaultContext _context;


        public CustomerRepository(DefaultContext context)
        {
            _context = context;
        }

        public Task<Customer?> GetByIdAsync(Guid customerId, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        //public async Task<Customer?> GetByIdAsync(Guid customerId, CancellationToken cancellationToken = default)
        //{
        //    return await _context.Customers.FirstOrDefaultAsync(o => o.Id == customerId, cancellationToken);
        //}
    }
}
