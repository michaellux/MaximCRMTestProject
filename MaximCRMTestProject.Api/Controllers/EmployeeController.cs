using MaximCRMTestProject.Application.Services.Employees.Commands.Create;
using MaximCRMTestProject.Application.Services.Employees.Commands.Delete;
using MaximCRMTestProject.Application.Services.Employees.Commands.Update;
using MaximCRMTestProject.Application.Services.Employees.Queries.Get;
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
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesDefaultResponseType]
    public async Task<IActionResult> GetById(Guid id)
    {
        if (id == Guid.Empty)
        {
            return BadRequest(id);
        }

        var query = new GetByIdQuery(new EmployeeId(id));

        var employeeResult = await _mediator.Send(query);

        if (employeeResult is null)
        {
            return NotFound();
        }

        return Ok(employeeResult);
    }

    [HttpPost("register")]
    [ProducesResponseType(typeof(EmployeeResponse), StatusCodes.Status201Created)]
    [ProducesDefaultResponseType]
    [ActionName(nameof(Register))]
    public async Task<IActionResult> Register(CreateEmployeeRequest request)
    {
        var command = new CreateCommand(request.FullName, request.Position);

        var employeeResult = await _mediator.Send(command);

        return Ok(employeeResult);
    }

    [HttpPut("update")]
    public async Task<IActionResult> Update(UpdateEmployeeRequest request)
    {
        var command = new UpdateCommand(request.id, request.FullName, request.Position);

        var employeeResult = await _mediator.Send(command);

        return Ok(employeeResult);
    }

    [HttpDelete("delete/{id:guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var command = new DeleteCommand(new EmployeeId(id));

        var employeeResult = await _mediator.Send(command);

        return NoContent();
    }
}