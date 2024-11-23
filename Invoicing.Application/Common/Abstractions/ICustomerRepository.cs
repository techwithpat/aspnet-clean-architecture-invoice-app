using Invoicing.Domain;
using Invoicing.Domain.Customers;

namespace Invoicing.Application;

public interface ICustomerRepository
{
    Task<IEnumerable<Customer>> GetAllAsync();
    Task<Customer?> GetByIdAsync(Guid customerId);
}