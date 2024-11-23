using Invoicing.Application;
using Invoicing.Domain;
using Invoicing.Domain.Customers;
using Microsoft.EntityFrameworkCore;

namespace Invoicing.Infrastructure;

internal class CustomerRepository(ApplicationDbContext dbContext)
    : ICustomerRepository
{
    public async Task<IEnumerable<Customer>> GetAllAsync() =>
        await dbContext.Customers.AsNoTracking().ToListAsync();

    public async Task<Customer?> GetByIdAsync(Guid customerId) =>
        await dbContext.Customers.FindAsync(customerId);
}