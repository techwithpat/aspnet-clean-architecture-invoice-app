using Invoicing.Domain.Customers;

namespace Invoicing.Infrastructure.Data;

public static class DbInitializer
{
    public static void Initialize(ApplicationDbContext applicationDbContext)
    {
        applicationDbContext.Database.EnsureCreated();
        
        var customers = applicationDbContext.Set<Customer>().ToList();
        if (customers.Count != 0) return;
        
        applicationDbContext.AddRange(
            new Customer("John Doe", "johndoe@example.com"),
            new Customer("Jane Smith", "janesmith@example.com"));
  
        applicationDbContext.SaveChanges();
    }
}