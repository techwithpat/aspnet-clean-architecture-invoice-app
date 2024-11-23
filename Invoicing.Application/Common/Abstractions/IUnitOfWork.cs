namespace Invoicing.Application;

public interface IUnitOfWork
{
    Task CommitAsync(CancellationToken cancellationToken);
}