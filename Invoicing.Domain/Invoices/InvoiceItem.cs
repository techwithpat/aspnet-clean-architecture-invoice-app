namespace Invoicing.Domain.Invoices;

public class InvoiceItem
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Description { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal TotalPrice => Quantity * UnitPrice;
}