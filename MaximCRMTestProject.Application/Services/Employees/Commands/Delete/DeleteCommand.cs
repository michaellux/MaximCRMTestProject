using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Commands.DeleteEmployees
{
    public record DeleteCommand(EmployeeId EmployeeId) : IRequest
    {
    }
}
