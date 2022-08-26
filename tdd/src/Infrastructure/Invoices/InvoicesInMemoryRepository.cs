using System.Collections.Concurrent;
using Application.Invoices;
using Domain.Invoices;

namespace Infrastructure.Invoices;

public class InvoicesInMemoryRepository : IInvoicesRepository
{
    private readonly ConcurrentBag<Invoice> _invoices = new(); 
    
    public Task<int> AddAsync(Invoice invoice, CancellationToken cancellationToken)
    {
        invoice.Id = invoice.GetHashCode();
        
        _invoices.Add(invoice);

        return Task.FromResult(invoice.Id);
    }
}