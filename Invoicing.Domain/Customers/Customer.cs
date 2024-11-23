using Invoicing.Domain.Abstractions;

namespace Invoicing.Domain.Customers;

public class Customer(string name, string email) : BaseEntity
{
    public string Name { get; private set; } = name;
    public string Email { get; private set; } = email;
}