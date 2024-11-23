using MediatR;

namespace Invoicing.Application.Invoices.GetInvoices;

public record GetInvoicesQuery : IRequest<IEnumerable<InvoiceResponse>>;