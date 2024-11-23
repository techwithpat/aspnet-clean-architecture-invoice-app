using Invoicing.Application;
using Invoicing.Domain;
using Invoicing.Domain.Invoices;
using Microsoft.EntityFrameworkCore;

namespace Invoicing.Infrastructure;

internal class InvoiceRepository(ApplicationDbContext dbContext)
    : IInvoiceRepository
{
    public void Add(Invoice invoice) => dbContext.Add(invoice);

    public async Task<IEnumerable<Invoice>> GetAllAsync() =>
        await dbContext.Invoices
            .AsTracking()
            .Include(i => i.Customer)
            .Include(i => i.Items)
            .ToListAsync();

    public IUnitOfWork UnitOfWork => dbContext;
}