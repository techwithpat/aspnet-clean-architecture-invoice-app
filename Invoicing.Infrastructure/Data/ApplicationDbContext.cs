using Invoicing.Application;
using Invoicing.Domain;
using Invoicing.Domain.Customers;
using Invoicing.Domain.Invoices;
using Microsoft.EntityFrameworkCore;

namespace Invoicing.Infrastructure;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options), IUnitOfWork
{
    public DbSet<Invoice> Invoices => Set<Invoice>();
    public DbSet<Customer> Customers => Set<Customer>();

    public Task CommitAsync(CancellationToken cancellationToken)
        => base.SaveChangesAsync(cancellationToken);
}