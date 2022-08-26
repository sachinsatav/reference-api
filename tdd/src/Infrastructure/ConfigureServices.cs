using Application.Invoices;
using Infrastructure.Invoices;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddSingleton<IInvoicesRepository, InvoicesInMemoryRepository>();

        return services;
    }
}
