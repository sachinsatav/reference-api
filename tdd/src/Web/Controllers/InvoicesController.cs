using System.Net;
using Application.Invoices;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class InvoicesController : ControllerBase
{
    private readonly ISender _sender;

    public InvoicesController(ISender sender)
    {
        _sender = sender ?? throw new ArgumentNullException(nameof(sender));
    }
    
    [HttpPost]
    [ProducesResponseType(typeof(int), (int)HttpStatusCode.Accepted)]
    public async Task<ActionResult> Create(CreateInvoiceCommand command, CancellationToken cancellationToken)
    {
        var id = await _sender.Send(command, cancellationToken);

        return Accepted(id);
    }
}