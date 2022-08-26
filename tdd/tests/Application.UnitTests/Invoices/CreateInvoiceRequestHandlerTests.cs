using Application.Invoices;
using AutoFixture.Xunit2;
using Domain.Invoices;
using FluentAssertions;
using NSubstitute;

namespace Application.UnitTests.Invoices;

public class CreateInvoiceCommandHandlerTests
{
    private readonly IInvoicesRepository _invoicesRepository = Substitute.For<IInvoicesRepository>(); 
    
    public class Handle : CreateInvoiceCommandHandlerTests
    {
        [Theory, AutoData]
        public async Task ReturnsNotZero_WhenRequestIsValid(CreateInvoiceCommand request, int expected)
        {
            _invoicesRepository.AddAsync(Arg.Any<Invoice>(), CancellationToken.None).Returns(expected);
            
            var handler = new CreateInvoiceCommandHandler(_invoicesRepository);

            var id = await handler.Handle(request, CancellationToken.None);

            id.Should().Be(expected);
        }
    }
}