namespace Invoicing.Domain.Invoices;

public enum InvoiceStatus
{
    Unpaid,
    Sent,
    Paid,
    Overdue
}