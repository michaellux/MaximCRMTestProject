using MaximCRMTestProject.Application.Services.Employees;
using MaximCRMTestProject.Contracts.Employees;
using Microsoft.AspNetCore.Mvc;

namespace MaximCRMTestProject.Api.Controllers;

[ApiController]
[Route("employees")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpPost("register")]
    public IActionResult Register(CreateEmployeeRequest request)
    {
        var employeeResult = _employeeService.Register(
            request.FullName,
            request.Position);

        var response = new EmployeeResponse(
            employeeResult.Id,
            employeeResult.FullName,
            employeeResult.Position);

        return Ok(response);
    }
}