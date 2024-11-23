using Invoicing.Domain;
using Invoicing.Domain.Invoices;

namespace Invoicing.Application;

public interface IInvoiceRepository
{
    void Add(Invoice invoice);
    Task<IEnumerable<Invoice>> GetAllAsync();
    IUnitOfWork UnitOfWork { get; }
}