namespace Invoicing.Application.Invoices.GetInvoices;

public record InvoiceResponse (
    Guid Id,
    string CustomerName,
    DateTime CreatedAt,
    string Status,
    List<InvoiceItemResponse> Items);
    
public record InvoiceItemResponse (
    string Description,
    int Quantity,
    decimal UnitPrice);