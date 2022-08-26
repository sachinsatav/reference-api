using Domain.Invoices;
using MediatR;

namespace Application.Invoices;

public class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, int>
{
    private readonly IInvoicesRepository _repository;

    public CreateInvoiceCommandHandler(IInvoicesRepository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }
    
    public async Task<int> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
    {
        var invoice = new Invoice()
        {
            Customer = request.Customer,
            Amount = request.Amount,
            Payments = request.Payments.Select(payment => new Payment(payment.Amount)).ToList()
        };

        return await _repository.AddAsync(invoice, cancellationToken);
    }
}