using MediatR;

namespace Invoicing.Application.Customers.GetCustomers;

internal class GetCustomersQueryHandler(ICustomerRepository customerRepository)
    : IRequestHandler<GetCustomersQuery, IEnumerable<CustomerResponse>>
{
    public async Task<IEnumerable<CustomerResponse>> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
    {
        var customers =  await customerRepository.GetAllAsync();
        return await Task.FromResult(customers.Select(c => new CustomerResponse(c.Id, c.Name, c.Email)).ToList());
    }
}