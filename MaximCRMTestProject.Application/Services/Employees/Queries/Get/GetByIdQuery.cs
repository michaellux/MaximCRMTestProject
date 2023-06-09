using MaximCRMTestProject.Application.Services.Employees.Common;
using MaximCRMTestProject.Domain.Entities;
using MediatR;

namespace MaximCRMTestProject.Application.Services.Employees.Queries.GetEmployees
{
    public record GetByIdQuery(EmployeeId EmployeeId) : IRequest<EmployeeResult>
    {
    }
}
