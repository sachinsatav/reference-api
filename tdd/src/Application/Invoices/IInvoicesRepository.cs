using Domain.Invoices;

namespace Application.Invoices;

public interface IInvoicesRepository
{
    Task<int> AddAsync(Invoice invoice, CancellationToken cancellationToken);
}