namespace Domain.Invoices;

public class Invoice
{
    public int Id { get; set; }
    public string Customer { get; set; }
    public decimal Amount { get; set; }
    public decimal AmountDue => Amount - (Payments?.Sum(payment => payment.Amount) ?? 0);
    public List<Payment>? Payments { get; set; }
}