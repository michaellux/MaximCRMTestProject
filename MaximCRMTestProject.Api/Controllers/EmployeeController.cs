using MaximCRMTestProject.Application.Services.Employees.Commands.CreateEmployees;
using MaximCRMTestProject.Application.Services.Employees.Queries.GetEmployees;
using MaximCRMTestProject.Contracts.Employees;
using MaximCRMTestProject.Domain.Entities;
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

    [HttpGet("get")]
    [ProducesResponseType(typeof(EmployeeResponse), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> GetAll()
    {
        var query = new GeAllQuery();

        var employeeResult = await _mediator.Send(query);

        return Ok(employeeResult);
    }

    [HttpGet("get/{id:guid}")]
    [ProducesResponseType(typeof(EmployeeResponse), StatusCodes.Status200OK)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> GetById(Guid id)
    {
        var query = new GetByIdQuery(new EmployeeId(id));

        var employeeResult = await _mediator.Send(query);

        return Ok(employeeResult);
    }

    [HttpPost("register")]
    [ProducesResponseType(typeof(EmployeeResponse), StatusCodes.Status201Created)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> Register(CreateEmployeeRequest request)
    {
        var command = new CreateCommand(request.FullName, request.Position);

        var employeeResult = await _mediator.Send(command);

        return CreatedAtAction(nameof(GetById), new { id = employeeResult.Id }, request);
    }
}