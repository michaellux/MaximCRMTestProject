using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Commands.Delete
{
    public record DeleteCommand(EmployeeId EmployeeId) : IRequest<EmployeeResult>
    {
    }
}
