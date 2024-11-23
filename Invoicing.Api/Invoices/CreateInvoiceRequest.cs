namespace Invoicing.Api.Invoices;

public record CreateInvoiceRequest (Guid CustomerId, List<CreateInvoiceItemRequest> Items);

public record CreateInvoiceItemRequest (string Description, int Quantity, decimal UnitPrice);