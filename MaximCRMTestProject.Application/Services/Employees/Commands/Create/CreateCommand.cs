using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Commands.CreateEmployees
{
    public record CreateCommand(
        string FullName,
        string Position) : IRequest<EmployeeResult>
    {
    }
}
