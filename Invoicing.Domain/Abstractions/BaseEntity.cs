namespace Invoicing.Domain.Abstractions;

public class BaseEntity
{
    public Guid Id { get; private set; } = Guid.NewGuid();
}