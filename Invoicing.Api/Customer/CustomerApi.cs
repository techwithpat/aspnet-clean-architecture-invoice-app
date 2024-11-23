using Invoicing.Application;
using Invoicing.Application.Customers.GetCustomers;
using MediatR;

namespace Invoicing.Api.Customer;

public static class CustomerApi
{
    public static void RegisterCustomerApi(this WebApplication app)
    {
        app.MapGet("/customers", async (IMediator mediator) =>
        {
            var customers = await mediator.Send(new GetCustomersQuery());
            return TypedResults.Ok(customers);
        }).WithName("GetAllCustomers");
    }
}