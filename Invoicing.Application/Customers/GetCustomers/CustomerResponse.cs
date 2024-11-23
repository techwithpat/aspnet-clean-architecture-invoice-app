namespace Invoicing.Application.Customers.GetCustomers;

public record CustomerResponse (Guid Id, string Name, string Email);