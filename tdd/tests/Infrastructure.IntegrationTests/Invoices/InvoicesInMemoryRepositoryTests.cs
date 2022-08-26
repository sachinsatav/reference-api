using AutoFixture.Xunit2;
using Domain.Invoices;
using FluentAssertions;
using Infrastructure.Invoices;

namespace Infrastructure.IntegrationTests.Invoices;

public class InvoicesInMemoryRepositoryTests
{
    public class AddAsync
    {
        [Theory, AutoData]
        public async Task ReturnsTheHashCode_WhenInvoiceIsValid(Invoice invoice)
        {
            var repository = new InvoicesInMemoryRepository();

            var id = await repository.AddAsync(invoice, CancellationToken.None);

            id.Should().NotBe(0);
        }
    }
}