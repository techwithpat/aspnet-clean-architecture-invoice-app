using Invoicing.Application;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Invoicing.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<ApplicationDbContext>(o =>
            o.UseInMemoryDatabase("InvoiceDb"));
        services.AddScoped<IUnitOfWork, ApplicationDbContext>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        services.AddScoped<IInvoiceRepository, InvoiceRepository>();
        return services;
    }
}