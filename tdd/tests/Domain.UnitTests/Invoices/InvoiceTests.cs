using Domain.Invoices;
using FluentAssertions;

namespace Domain.UnitTests.Invoices;

public class InvoiceTests
{
    public class AmountDue
    {
        [Fact]
        public void ReturnsZero_WhenAllPaymentsHaveMade()
        {
            var invoice = new Invoice()
            {
                Amount = 100,
                Payments = new List<Payment>
                {
                    new(50),
                    new(50)
                }
            };

            invoice.AmountDue.Should().Be(0);
        }

        [Fact]
        public void ReturnsTheAmount_WhenThePaymentsCollectionIsNull()
        {
            var invoice = new Invoice()
            {
                Amount = 100
            };

            invoice.AmountDue.Should().Be(100);
        }
    }
}