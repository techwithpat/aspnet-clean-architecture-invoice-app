using MediatR;

namespace Invoicing.Application.Customers.GetCustomers;

public record GetCustomersQuery : IRequest<IEnumerable<CustomerResponse>>;