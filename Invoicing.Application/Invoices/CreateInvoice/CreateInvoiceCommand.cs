using Invoicing.Domain;
using Invoicing.Domain.Invoices;
using MediatR;

namespace Invoicing.Application;

public record CreateInvoiceCommand(
    Guid CustomerId,
    List<InvoiceItem> Items) : IRequest<Guid>;