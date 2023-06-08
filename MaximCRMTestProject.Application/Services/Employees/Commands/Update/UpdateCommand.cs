using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Commands.UpdateEmployees
{
    public record UpdateCommand(EmployeeId EmployeeId, string FullName, string Position) : IRequest;
}
