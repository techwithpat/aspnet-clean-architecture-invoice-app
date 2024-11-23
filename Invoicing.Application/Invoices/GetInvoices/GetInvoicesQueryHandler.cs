using MediatR;

namespace Invoicing.Application.Invoices.GetInvoices;

internal class GetInvoicesQueryHandler(IInvoiceRepository invoiceRepository)
    : IRequestHandler<GetInvoicesQuery, IEnumerable<InvoiceResponse>>
{
    public async Task<IEnumerable<InvoiceResponse>> Handle(
        GetInvoicesQuery request, CancellationToken cancellationToken)
    {
        var invoices = await invoiceRepository.GetAllAsync();
        return invoices.Select(i => new InvoiceResponse(
            i.Id,
            i.Customer?.Name!,
            i.CreatedAt,
            i.Status.ToString(),
            i.Items.Select(item =>
                    new InvoiceItemResponse(item.Description, item.Quantity, item.UnitPrice))
                .ToList()
        ));
    }
}