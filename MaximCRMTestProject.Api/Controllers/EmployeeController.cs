using MaximCRMTestProject.Application.Services.Employees.Commands.CreateEmployees;
using MaximCRMTestProject.Contracts.Employees;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MaximCRMTestProject.Api.Controllers;

[ApiController]
[Route("employees")]
public class EmployeeController : ControllerBase
{
    private readonly ISender _mediator;

    public EmployeeController(ISender mediator)
    {
        _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
    }

    [HttpPost("register")]
    [ProducesResponseType(typeof(EmployeeResponse), StatusCodes.Status201Created)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> Register(CreateEmployeeRequest request)
    {
        var command = new CreateCommand(request.FullName, request.Position);

        var employeeResult = await _mediator.Send(command);

        return Ok(employeeResult);
    }
}