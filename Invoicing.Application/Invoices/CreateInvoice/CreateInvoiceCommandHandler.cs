using Invoicing.Domain;
using Invoicing.Domain.Invoices;
using MediatR;

namespace Invoicing.Application;

internal class CreateInvoiceCommandHandler(
    IInvoiceRepository invoiceRepository,
    ICustomerRepository customerRepository
) : IRequestHandler<CreateInvoiceCommand, Guid>
{
    public async Task<Guid> Handle(
        CreateInvoiceCommand request, CancellationToken cancellationToken)
    {
        var customer = await customerRepository.GetByIdAsync(request.CustomerId);
        if(customer == null) throw new ArgumentException(nameof(request.CustomerId));

        var invoice = Invoice.CreateNew(customer, request.Items);
        invoiceRepository.Add(invoice);
        
        await invoiceRepository.UnitOfWork.CommitAsync(cancellationToken);
        return invoice.Id;
    }
}