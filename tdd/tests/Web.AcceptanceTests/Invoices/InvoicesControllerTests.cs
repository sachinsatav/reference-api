using System.Net;
using System.Net.Mime;
using System.Text;
using System.Text.Json;
using Application.Invoices;
using AutoFixture.Xunit2;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Web.AcceptanceTests.Invoices;

public class InvoicesControllerTests : IClassFixture<WebApplicationFactory<WebProgram>>
{
    private readonly HttpClient _client;
    
    public InvoicesControllerTests(WebApplicationFactory<WebProgram> factory)
    {
         _client = factory.CreateClient();
    }
    
    [Theory, AutoData]
    public async Task ReturnsAccepted_WhenRequestIsValid(CreateInvoiceCommand command)
    {
        var data = JsonSerializer.Serialize(command);

        var content = new StringContent(data, Encoding.UTF8, MediaTypeNames.Application.Json);
        
        var response = await _client.PostAsync("/invoices", content);

        response.StatusCode.Should().Be(HttpStatusCode.Accepted);
    }
}