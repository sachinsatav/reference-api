using MediatR;

namespace Application.Invoices;

public class CreateInvoiceCommand : IRequest<int>
{
    public string Customer { get; set; }
    public decimal Amount { get; set; }
    public List<CreateInvoicePayment> Payments { get; set; }
}