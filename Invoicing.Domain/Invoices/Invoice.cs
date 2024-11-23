using Invoicing.Domain.Abstractions;
using Invoicing.Domain.Customers;

namespace Invoicing.Domain.Invoices;

public class Invoice : BaseEntity
{
    public Customer Customer { get; set; } = default!;
    public DateTime DueAt { get; private set; }
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime SentAt { get; private set; }
    public InvoiceStatus Status { get; set; } = InvoiceStatus.Unpaid;
    public List<InvoiceItem> Items { get; set; } = [];

    public static Invoice CreateNew(Customer customer, List<InvoiceItem> items)
    {
        var invoice = new Invoice
        {
            Customer = customer,
            Items = items
        };
        return invoice;
    }

    public void MarkAsPaid() => Status = InvoiceStatus.Paid;

    public void MarkAsSent()
    {
        Status = InvoiceStatus.Sent;
        SentAt = DateTime.UtcNow;
        DueAt = DateTime.UtcNow.AddMonths(1);
    }
}